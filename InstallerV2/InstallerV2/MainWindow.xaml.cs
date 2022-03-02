using System.Windows;
using System.Windows.Input;
using System.Threading;

namespace InstallerV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            (bool, string) resp = Extensions.package.validate_section("CONFIG", new string[] { "name", "type", "file", "default_path", "size" });
            if (resp.Item1 != true)
            {
                MessageBox.Show("The package.ini isn't valid. You can't run this installer. \nPlease contact with the project author or who sent this to you.", "Easy Installer V2", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();   
            }
            TextBlock1.Text = "Easy Installer V2\nfor %name%".Replace("%name%", Extensions.package["CONFIG"]["name"]);
            TextBlock2.Text = "v%version% [%date%] %uuid%".Replace("%version%", Properties.config.version).Replace("%date%", Properties.config.date).Replace("%uuid%", Properties.config.uuid);
        }

        private void button_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            button_exit.Visibility = Visibility.Hidden;
            void _click()
            {
                Thread.Sleep(2100);
                Dispatcher.Invoke(() =>
                {
                    Extensions.Forward();
                });
            }
            Thread t = new Thread(new ThreadStart(_click));
            t.Start();
        }
    }
}
