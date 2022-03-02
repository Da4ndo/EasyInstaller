using System;
using System.Windows.Forms;

namespace Installer
{
    public partial class Form1 : Form
    {
        public string path;
        public string[] panel_list = { "eula", "path", "installing", "finish"};
        public UserControl eula_panel = new Panels.eula();
        public UserControl path_panel = new Panels.path();
        public UserControl installing_panel = new Panels.installing();
        public UserControl finish_panel = new Panels.finish();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            version_label.Text = version_label.Text.Replace("%version%", Properties.config.version).Replace("%date%", Properties.config.date).Replace("%uuid%", extension.package["CONFIG"]["uuid"]);
            Text = Text.Replace("%name%", extension.package["CONFIG"]["name"]);
            label3.Text = label3.Text.Replace("%name%", extension.package["CONFIG"]["name"]);
            label1.Text = label1.Text.Replace("%name%", extension.package["CONFIG"]["name"]);

            panel3.Controls.Add(eula_panel);
            panel3.Controls.Add(path_panel);
            panel3.Controls.Add(installing_panel);
            panel3.Controls.Add(finish_panel);
        }
        public void exitP()
        {
            Close();
        }
    }
}
