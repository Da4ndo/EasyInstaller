using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InstallerV2
{
    /// <summary>
    /// Interaction logic for eula.xaml
    /// </summary>
    public partial class eula : Page
    {
        public eula()
        {
            InitializeComponent();
        }

        private void button_agree_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                Extensions.Forward();
            });
        }

        private void button_decline_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("You declined the eula. Do you want to exit the installer?", "Easy Installer V2", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (dialogResult == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock_eula.Text = Properties.Resources.eula;
        }
    }
}
