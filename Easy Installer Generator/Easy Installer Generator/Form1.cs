using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Easy_Installer_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PreviewClass.previews["Installer"] = false;
            PreviewClass.previews["InstallerV2"] = false;
        }

        public string file_type = "online";
        public int installerv = 2;
        public string eulap;

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) checkBox1.Checked = true;
            checkBox2.Checked = false;
            file_type = "online";
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false) checkBox2.Checked = true;
            checkBox1.Checked = false;
            file_type = "offline";
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false) checkBox4.Checked = true;
            checkBox3.Checked = false;
            installerv = 2;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false) checkBox3.Checked = true;
            checkBox4.Checked = false;
            installerv = 1;
        }

        private bool validate_input_data()
        {
            bool retval = true;

            if (textBox1.Text == string.Empty)
            {
                label7.Visible = true;
                retval = false;
            }
            else
                label7.Visible = false;

            if (textBox5.Text == string.Empty)
            {
                label6.Visible = true;
                retval = false;
            }
            else
                label6.Visible = false;

            if (textBox3.Text == string.Empty)
            {
                label8.Visible = true;
                retval = false;
            }
            else
                label8.Visible = false;

            if (textBox4.Text == string.Empty)
            {
                label9.Visible = true;
                retval = false;
            }
            else
                label9.Visible = false;

            if (eula_path.Text == string.Empty)
            {
                label11.Visible = true;
                retval = false;
            }
            else
                label11.Visible = false;

            return retval;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate_input_data() == false) 
                return;
            if (installerv > 1)
            {
                if (!Directory.Exists($"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}\\"))
                {
                    MessageBox.Show($"InstallerV{installerv}'s directory is not existing in the current directory. Generating stopped.", "Easy Installer Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string config_text =
                    "[CONFIG]\n" +
                    $"name = {textBox1.Text}\n" +
                    $"type = {file_type}\n" +
                    $"file = {textBox5.Text}\n" +
                    $"default_path = {textBox4.Text}\n" +
                    $"size = {textBox3.Text.ToString().Replace(" ", "")}";

                File.WriteAllText($"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}\\InstallerV{installerv}\\package.ini", config_text);

                File.Copy(eulap, $"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}\\InstallerV{installerv}\\Resources\\eula.txt", true);

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C msbuild \"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}\\InstallerV{installerv}.sln\" /t:InstallerV{installerv}";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                try
                { File.Copy($"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}\\InstallerV{installerv}\\bin\\Debug\\InstallerV{installerv}.exe", $"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}.exe", true); }
                catch (FileNotFoundException)
                { File.Copy($"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}\\InstallerV{installerv}\\bin\\Release\\InstallerV{installerv}.exe", $"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}.exe", true); }

                MessageBox.Show($"Done. File copied to {Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}.exe", "Easy Installer Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                if (!Directory.Exists($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer\\"))
                {
                    MessageBox.Show($"Installer's directory is not existing in the current directory. Generating stopped.", "Easy Installer Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string config_text =
                    "[CONFIG]\n" +
                    $"name = {textBox1.Text}\n" +
                    $"type = {file_type}\n" +
                    $"file = {textBox5.Text}\n" +
                    $"default_path = {textBox4.Text}\n" +
                    $"size = {textBox3.Text.ToString().Replace(" ", "")}\n" +
                    $"uuid = {Guid.NewGuid()}";

                File.WriteAllText($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer\\Installer\\package.ini", config_text);

                File.Copy(eulap, $"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer\\Installer\\Resources\\eula.txt", true);

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C msbuild \"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer\\Installer.sln\" /t:Installer";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                try
                { File.Copy($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer\\Installer\\bin\\Debug\\Installer.exe", $"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer.exe", true); }
                catch (FileNotFoundException)
                { File.Copy($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer\\Installer\\bin\\Release\\Installer.exe", $"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer.exe", true); }

                MessageBox.Show($"Done. File copied to {Path.GetDirectoryName(Application.ExecutablePath)}\\Installer.exe", "Easy Installer Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                eulap = openFileDialog1.FileName;
                if (openFileDialog1.FileName.Length > 50)
                    eula_path.Text = "..." + openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 50);
                else
                    eula_path.Text = openFileDialog1.FileName;
                eula_path.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (installerv > 1)
            {

                if (PreviewClass.previews[$"InstallerV{installerv}"])
                {
                    MessageBox.Show($"A Preview of InstallerV{installerv} is already open. Please, close it first!", "Easy Installer Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var f = new preview(previewof: $"InstallerV{installerv}", image_path: $"{Path.GetDirectoryName(Application.ExecutablePath)}\\InstallerV{installerv}\\InstallerV{installerv}\\images\\");
                f.Show();
                PreviewClass.previews[$"InstallerV{installerv}"] = true;
            }
            else
            {
                if (PreviewClass.previews[$"Installer"])
                {
                    MessageBox.Show($"A Preview of Installer is already open. Please, close it first!", "Easy Installer Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var f = new preview(previewof: $"Installer", image_path: $"{Path.GetDirectoryName(Application.ExecutablePath)}\\Installer\\Installer\\images\\");
                f.Show();
                PreviewClass.previews["Installer"] = true;
            }
        }
    }
}
