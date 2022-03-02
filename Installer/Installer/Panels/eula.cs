using System;
using System.Windows.Forms;

namespace Installer.Panels
{
    public partial class eula : UserControl
    {
        public eula()
        {
            InitializeComponent();
        }

        private void eula_Load(object sender, EventArgs e)
        {
            eula_textbox.Text = Properties.Resources.eula;
        }
        private void accept_eula_button_Click(object sender, EventArgs e)
        {
            new Step().Forward(ParentForm, "eula", "path");
        }
    }
}
