using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer.Panels
{
    public partial class finish : UserControl
    {
        public finish()
        {
            InitializeComponent();
        }

        private void finish_Load(object sender, EventArgs e)
        {
            label4.Text = label4.Text.Replace("%name%", extension.package["CONFIG"]["name"]);
            label4.Location = new Point((Width - label4.Width) / 2, 30);
            pictureBox2.Location = new Point((Width - pictureBox2.Width) / 2, 90);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            new Step().Exit(ParentForm);
        }
    }
}
