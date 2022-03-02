using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace InstallerV2
{
    /// <summary>
    /// Interaction logic for path.xaml
    /// </summary>
    public partial class path : Page
    {
        public path()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_path.Text.EndsWith("\\") || TextBox_path.Text.EndsWith("/")) { TextBox_path.Text = TextBox_path.Text.Remove(TextBox_path.Text.Length - 1, 1); }
            if (TextBox_path.Text == "" || TextBox_path.Text.StartsWith("C:\\Windows\\System32"))
            {
                MessageBox.Show("Invalid path. Path cannot be empty or system folder.", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Extensions.installation_path = TextBox_path.Text;

            Dispatcher.Invoke(() =>
            {
                Extensions.Forward();
            });
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                Extensions.Back();
            });
        }

        private void button_ChoosePath_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folderdialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBox_path.Text = folderdialog.SelectedPath;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock_size.Text =  "Space required on drive: " + Extensions.SizeSuffix(Int64.Parse(Extensions.package["CONFIG"]["size"]));
            TextBox_path.Text = Extensions.package["CONFIG"]["default_path"].Replace("{USERPROFILE}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        }

        private void TextBox_path_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                DriveInfo dDrive = new DriveInfo(TextBox_path.Text.Split(':')[0]);
                if (dDrive.IsReady)
                {
                    TextBlock_drivesize.Text = "Space available on drive: " + Extensions.SizeSuffix(Int64.Parse(dDrive.AvailableFreeSpace.ToString()));
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
