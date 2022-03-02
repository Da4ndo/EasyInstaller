using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Drawing;
using System.Net;
using System.Threading;
using Salaros.Configuration;
using IWshRuntimeLibrary;

namespace Installer.Panels
{
    public partial class installing : UserControl
    {
        public string file_name = "";
        public ConfigManager settings;
        public bool can_go_to_next = false;
        public installing()
        {
            InitializeComponent();
        }

        private void installing_Load(object sender, EventArgs e)
        {
            label5.Text = label5.Text.Replace("%size%", extension.SizeSuffix(Int64.Parse(extension.package["CONFIG"]["size"])));
            label6.Text = "Waiting to press install button...";
            label5.Location = new Point((Width - label5.Width) / 2, 259);
            label6.Location = new Point((Width - label6.Width) / 2, 11);
            progressBar.Location = new Point((Width - progressBar.Width) / 2, 44);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (extension.package["CONFIG"]["type"].ToLower() == "online")
            {
                changeInstallText("Downloading files...");

                file_name = @".\\" + extension.package["CONFIG"]["file"].Split('/')[extension.package["CONFIG"]["file"].Split('/').Length - 1];
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                    wc.DownloadFileAsync(
                        new Uri(extension.package["CONFIG"]["file"]),
                        file_name
                    );
                }

                while (true)
                {
                    if (can_go_to_next)
                    {
                        can_go_to_next = false;
                        installing_files();
                        break;
                    }
                }
            }
            else
            {
                file_name = extension.package["CONFIG"]["file"];
                for (int i = 0; i <= 50; i++)
                {
                    progressBar.Percentage = i;
                }
                installing_files();

            }
        }   
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Percentage = e.ProgressPercentage / 2;
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Downloading cancelled.", "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
            }

            else if (e.Error != null)
            {
                MessageBox.Show("Cannot download files. " + e.Error.Message, "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clean();
            }
            else
            {
                can_go_to_next = true;
            }
        }

        private void clean()
        {
            if (System.IO.File.Exists(file_name))
            {
                System.IO.File.Delete(file_name);
            }
        }

        public void changeInstallText(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(changeInstallText), new object[] { value });
                return;
            }
            label6.Text = value;
            label6.Location = new Point((Width - label6.Width) / 2, 11);
        }

        private void installing_files()
        {
            can_go_to_next = true;

            string format_path(string path)
            {
                return path.Replace("{INSTALLATION_PATH}", extension.installation_path).Replace("{USERPROFILE}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            }

            ConfigManager settings;
            if (!System.IO.File.Exists(file_name) && !System.IO.File.Exists(extension.package["CONFIG"]["file"]))
            {
                progressBar.Percentage = 0;
                can_go_to_next = false;
                MessageBox.Show($"File not found. The file not exists in the current directory or the given file link is invalid.", "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Installing cancelled.", "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (ZipArchive archive = ZipFile.OpenRead(file_name))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(archive.GetEntry("settings.cfg").Open()))
                    {
                        settings = new ConfigManager(sr.ReadToEnd(), new ConfigParserSettings
                        {
                            MultiLineValues = MultiLineValues.AllowValuelessKeys,
                        });
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File is not valid. File not found 'settings.cfg' for installaion settings.", "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar.Percentage = 0;
                    can_go_to_next = false;
                    return;
                }
                catch (IOException e)
                {
                    MessageBox.Show("File reading/writing (IO) exception. " + e.Message, "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar.Percentage = 0;
                    can_go_to_next = false;
                    return;

                }
                catch ( Exception e)
                {
                    MessageBox.Show("Unknown Error. " + e.Message, "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar.Percentage = 0;
                    can_go_to_next = false;
                    return;

                }

                int PercentbyFile = 49 / archive.Entries.Count;
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName == "settings.cfg" || entry.FullName.EndsWith("\\") || entry.FullName.EndsWith("/") || entry.FullName.EndsWith("/.") || entry.FullName.EndsWith("\\."))
                        continue;
                    changeInstallText("Installing " + entry.FullName);

                    try
                    {
                        if (settings.exists_key("INSTALLATION", entry.FullName))
                        {
                            (new FileInfo(format_path(settings["INSTALLATION"][entry.FullName]))).Directory.Create();
                            entry.ExtractToFile(format_path(settings["INSTALLATION"][entry.FullName]), true);
                        }
                        else
                        {
                            try
                            {
                                (new FileInfo(format_path(Path.Combine(settings["SETTINGS"]["default_files_location"], entry.FullName)))).Directory.Create();
                                entry.ExtractToFile(format_path(Path.Combine("{INSTALLATION_PATH}", entry.FullName)), true);
                            }
                            catch
                            {
                                (new FileInfo(format_path(Path.Combine("{INSTALLATION_PATH}", entry.FullName)))).Directory.Create();
                                entry.ExtractToFile(format_path(Path.Combine("{INSTALLATION_PATH}", entry.FullName)), true);
                            }
                        }
                        progressBar.Percentage += PercentbyFile;
                    }
                    catch (Exception e)
                    {
                        DialogResult dialogResult = MessageBox.Show("Error while installing file '" + entry.FullName +"'. " + e.Message + "\nDo you want to continue the installation?", "Easy Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.No)
                        {
                            progressBar.Percentage = 0;
                            can_go_to_next = false; 
                            return;
                        }
                    }
                }  

                if (settings.exists_section("RegisterControlPanelProgram"))
                {
                    (bool, string) resp = settings.validate_section("RegisterControlPanelProgram", new string[] {"name", "publisher", "installation_path", "display_icon", "display_version" } );
                    if (resp.Item1)
                    {
                        changeInstallText("Setting up app registration... ");

                        try
                        {
                        extension.RegisterControlPanelProgram(settings["RegisterControlPanelProgram"]["name"], settings["RegisterControlPanelProgram"]["publisher"], format_path(settings["RegisterControlPanelProgram"]["installation_path"]), format_path(settings["RegisterControlPanelProgram"]["display_icon"]), format_path(settings["RegisterControlPanelProgram"]["uninstallstring"]), settings["RegisterControlPanelProgram"]["display_version"]);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Unknown Error. " + e.Message, "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Installing cancelled.", "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            progressBar.Percentage = 0;
                            can_go_to_next = false;
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"Not valid config file. [RegisterControlProgram] ==> Missing: {resp.Item2}", "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Installing cancelled.", "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        progressBar.Percentage = 0;
                        can_go_to_next = false; 
                        return;

                    }
                }

                if (settings.exists_section("Shortcut"))
                {
                    WshShell shell = new WshShell();
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{settings["Shortcut"]["name"]}.lnk"));

                    if (settings.exists_key("Shortcut", "description"))
                        shortcut.Description = settings["Shortcut"]["description"];
                    else
                        shortcut.Description = "This shortcut made with Easy Installer V2 by Da4ndo.";

                    shortcut.IconLocation = @format_path(settings["Shortcut"]["icon"]);
                    shortcut.TargetPath = format_path(settings["Shortcut"]["target"]);
                    if (settings.exists_key("Shortcut", "hotkey"))
                        shortcut.Hotkey = settings["Shortcut"]["hotkey"];
                    shortcut.Save();
                }

                progressBar.Percentage = 100;

            }
            can_go_to_next = true;
            Thread.Sleep(500);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (can_go_to_next)
            {
                if (extension.package["CONFIG"]["type"] == "online") System.IO.File.Delete(file_name);
                new Step().Forward(ParentForm, "installing", "finish");
            }
            else
            {
                changeInstallText("Waiting to press install button...");
                install_button.Enabled = true;
            }
        }

        private void install_button_Click(object ss, EventArgs ee)
        {
            install_button.Enabled = false;

            if (backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new Step().Back(ParentForm, "installing", "path");
        }
    }
}