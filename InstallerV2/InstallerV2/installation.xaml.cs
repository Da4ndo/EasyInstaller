using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.IO;
using System.IO.Compression;
using System.Net;
using Salaros.Configuration;
using System.Threading;
using IWshRuntimeLibrary;

namespace InstallerV2
{
    /// <summary>
    /// Interaction logic for installation.xaml
    /// </summary>
    public partial class installation : Page
    {
        public string file_name = "";
        public ConfigManager settings;
        public bool can_go_to_next = false;
        public installation()
        {
            InitializeComponent();
        }

        private void button_install_Click(object sender, RoutedEventArgs e)
        {
            button_install.IsEnabled = false;
            BackgroundWorker backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.RunWorkerAsync();

        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                Extensions.Back();
            });
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Extensions.package["CONFIG"]["type"].ToLower() == "online")
            {
                Dispatcher.Invoke(() =>
                {
                    TextBlock1.Text = "Downloading files...";
                });
                file_name = @".\\" + Extensions.package["CONFIG"]["file"].Split('/')[Extensions.package["CONFIG"]["file"].Split('/').Length - 1];

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                    wc.DownloadFileAsync(
                        new Uri(Extensions.package["CONFIG"]["file"]),
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
                file_name = Extensions.package["CONFIG"]["file"];
                for (int i = 0; i <= 50; i++)
                {
                    Dispatcher.Invoke(() =>
                    {
                        progressBar.Value = i;
                        progressBar_Percentage.Text = $"{i}%";
                    });
                }
                installing_files();

            }
        }
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                progressBar.Value = e.ProgressPercentage / 2;
                progressBar_Percentage.Text = $"{(e.ProgressPercentage / 2)}%";
            });
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Downloading cancelled.", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Information);
                clean();
            }

            else if (e.Error != null)
            {
                MessageBox.Show("Cannot download files. " + e.Error.Message, "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Error);
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

        private void installing_files()
        {
            can_go_to_next = true;

            string format_path(string path)
            {
                return path.Replace("{INSTALLATION_PATH}", Extensions.installation_path).Replace("{USERPROFILE}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            }

            ConfigManager settings;
            if (!System.IO.File.Exists(file_name) && !System.IO.File.Exists(Extensions.package["CONFIG"]["file"]))
            {
                Dispatcher.Invoke(() =>
                {
                    progressBar.Value = 0;
                    progressBar_Percentage.Text = "0%";
                });
                can_go_to_next = false;
                MessageBox.Show($"File not found. The file not exists in the current directory or the given file link is invalid.", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Information);
                MessageBox.Show("Installing cancelled.", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Information);
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
                    MessageBox.Show("File is not valid. File not found 'settings.cfg' for installaion settings.", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Error);
                    Dispatcher.Invoke(() =>
                    {
                        progressBar.Value = 0;
                        progressBar_Percentage.Text = "0%";
                    });
                    can_go_to_next = false;
                    return;
                }
                catch (IOException e)
                {
                    MessageBox.Show("File reading/writing (IO) exception. " + e.Message, "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Error);
                    Dispatcher.Invoke(() =>
                    {
                        progressBar.Value = 0;
                        progressBar_Percentage.Text = "0%";
                    });
                    can_go_to_next = false;
                    return;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Unknown Error. " + e.Message, "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Error);
                    Dispatcher.Invoke(() =>
                    {
                        progressBar.Value = 0;
                        progressBar_Percentage.Text = "0%";
                    });
                    can_go_to_next = false;
                    return;

                }

                int PercentbyFile = 49 / archive.Entries.Count;
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName == "settings.cfg" || entry.FullName.EndsWith("\\") || entry.FullName.EndsWith("/") || entry.FullName.EndsWith("/.") || entry.FullName.EndsWith("\\."))
                        continue;
                    Dispatcher.Invoke(() =>
                    {
                        TextBlock1.Text = $"Installing {entry.FullName}";
                    });

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
                                (new FileInfo(format_path(System.IO.Path.Combine(settings["SETTINGS"]["default_files_location"], entry.FullName)))).Directory.Create();
                                entry.ExtractToFile(format_path(System.IO.Path.Combine("{INSTALLATION_PATH}", entry.FullName)), true);
                            }
                            catch
                            {
                                (new FileInfo(format_path(System.IO.Path.Combine("{INSTALLATION_PATH}", entry.FullName)))).Directory.Create();
                                entry.ExtractToFile(format_path(System.IO.Path.Combine("{INSTALLATION_PATH}", entry.FullName)), true);
                            }
                        }
                        Dispatcher.Invoke(() =>
                        {
                            progressBar.Value += PercentbyFile;
                            progressBar_Percentage.Text = $"{int.Parse(progressBar_Percentage.Text.Replace("%", "")) + PercentbyFile}%";
                        });
                    }
                    catch (Exception e)
                    {
                        MessageBoxResult dialogResult = MessageBox.Show("Error while installing file '" + entry.FullName + "'. " + e.Message + "\nDo you want to continue the installation?", "Easy Installer V2", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        if (dialogResult == MessageBoxResult.No)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                progressBar.Value = 0;
                                progressBar_Percentage.Text = "0%";
                            });
                            can_go_to_next = false;
                            return;
                        }
                    }
                }

                if (settings.exists_section("RegisterControlPanelProgram"))
                {
                    (bool, string) resp = settings.validate_section("RegisterControlPanelProgram", new string[] { "name", "publisher", "installation_path", "display_icon", "display_version" });
                    if (resp.Item1)
                    {
                        Dispatcher.Invoke(() =>
                        {
                            TextBlock1.Text = $"Setting up app registration... ";
                        });

                        try
                        {
                            Extensions.RegisterControlPanelProgram(settings["RegisterControlPanelProgram"]["name"], settings["RegisterControlPanelProgram"]["publisher"], format_path(settings["RegisterControlPanelProgram"]["installation_path"]), format_path(settings["RegisterControlPanelProgram"]["display_icon"]), format_path(settings["RegisterControlPanelProgram"]["uninstallstring"]), settings["RegisterControlPanelProgram"]["display_version"]);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Unknown Error. " + e.Message, "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Error);
                            MessageBox.Show("Installing cancelled.", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Information);
                            Dispatcher.Invoke(() =>
                            {
                                progressBar.Value = 0;
                                progressBar_Percentage.Text = "0%";
                            });
                            can_go_to_next = false;
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show($"Not valid config file. [RegisterControlProgram] ==> Missing: {resp.Item2}", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Error);
                        MessageBox.Show("Installing cancelled.", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Information);
                        Dispatcher.Invoke(() =>
                        {
                            progressBar.Value = 0;
                            progressBar_Percentage.Text = "0%";
                        });
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

                Dispatcher.Invoke(() =>
                {
                    progressBar.Value = 100;
                    progressBar_Percentage.Text = "100%";

                });
            }
            can_go_to_next = true;
            Thread.Sleep(500);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (can_go_to_next) Dispatcher.Invoke(() =>
            {
                if (Extensions.package["CONFIG"]["type"] == "online") System.IO.File.Delete(file_name);     
                Extensions.Forward();

            });
            else Dispatcher.Invoke(() =>
            {
                TextBlock1.Text = $"Waiting to press install button...";
                button_install.IsEnabled = true;

            });
        }
    }
}
