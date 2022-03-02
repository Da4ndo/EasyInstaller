using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace InstallerV2
{
    /// <summary>
    /// Interaction logic for finish.xaml
    /// </summary>
    public partial class finish : Page
    {
        public finish()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = $"Thank you for installing {Extensions.package["CONFIG"]["name"]}!";
            /* string xml = $@"<toast>
                      <visual>
                        <binding template='ToastGeneric'>
                          <text>Expense added</text>
                          <text>Description: 2 - Amount: 1 </text>
                        </binding>
                      </visual>
                    </toast>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            ToastNotification toast = new ToastNotification(doc);
            ToastNotificationManager.CreateToastNotifier("").Show(toast);*/

        }

        private void button_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
