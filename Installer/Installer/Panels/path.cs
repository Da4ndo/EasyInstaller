using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Installer.Panels
{
    public partial class path : UserControl
    {
        public path()
        {
            InitializeComponent();
        }

        private void path_Load(object sender, EventArgs e)
        {
            pathlabel.Location = new Point(((Width - pathlabel.Width) / 2) - 140, 129);
            textBox1.Location = new Point((Width - textBox1.Width) / 2, 125);
            cpath_button.Location = new Point(((Width - cpath_button.Width) / 2) + 125, 126);

            label1.Location = new Point((Width - label1.Width) / 2 + 5, 22);

            textBox1.Text = extension.package["CONFIG"]["default_path"].Replace("{USERPROFILE}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            label4.Text = extension.SizeSuffix(Int64.Parse(extension.package["CONFIG"]["size"]));

            label2.Location = new Point(((Width - label2.Width) / 2) - 121 + 16, 219);
            label3.Location = new Point(((Width - label3.Width) / 2) - 96 + 16, 248);
            label4.Location = new Point(((Width - label4.Width) / 2) + 115 + 16, 219);
            label5.Location = new Point(((Width - label5.Width) / 2) + 115 + 16, 248);

        }

        private void path_next_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith("\\") || textBox1.Text.EndsWith("/")) { textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1); }
            if (textBox1.Text == "" || textBox1.Text.StartsWith("C:\\Windows\\System32"))
            {
                MessageBox.Show("Invalid path. Path cannot be empty or system folder.", "Easy Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            extension.installation_path = textBox1.Text;
            new Step().Forward(ParentForm, "path", "installing");
        }

        private void cpath_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new Step().Back(ParentForm, "path", "eula");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DriveInfo dDrive = new DriveInfo(textBox1.Text.Split(':')[0]);
                if (dDrive.IsReady)
                {
                    label5.Text = extension.SizeSuffix(Int64.Parse(dDrive.AvailableFreeSpace.ToString()));
                }
            }
            catch (Exception) 
            {
                return;
            }
        }
    }
}
