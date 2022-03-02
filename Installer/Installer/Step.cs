using System;
using System.Windows.Forms;
using System.Drawing;

namespace Installer
{
    internal class Step
    {
        public void Back(Form ParentForm, string currentPageName, string previousPageName)
        {
            XanderUI.XUICustomPictureBox currentPictureBox = (XanderUI.XUICustomPictureBox)ParentForm.Controls.Find(currentPageName + "_pbox", false)[0];
            currentPictureBox.Image = Properties.Resources.pending;

            XanderUI.XUICustomPictureBox previousPictureBox = (XanderUI.XUICustomPictureBox)ParentForm.Controls.Find(previousPageName + "_pbox", false)[0];
            previousPictureBox.Image = Properties.Resources.current;

            Panel nextLine = (Panel)ParentForm.Controls.Find(previousPageName + "_step", false)[0];
            nextLine.BackColor = Color.FromArgb(224, 224, 224);

            Label currentLabel = (Label)ParentForm.Controls.Find(currentPageName + "_label", false)[0];
            currentLabel.ForeColor = Color.Black;

            ParentForm.Controls.Find("panel3", false)[0].Controls.Find(previousPageName, false)[0].BringToFront();
        }

        public void Forward(Form ParentForm, string currentPageName, string nextPageName)
        {
            XanderUI.XUICustomPictureBox currentPictureBox = (XanderUI.XUICustomPictureBox)ParentForm.Controls.Find(currentPageName + "_pbox", false)[0];
            currentPictureBox.Image = Properties.Resources.completed;

            XanderUI.XUICustomPictureBox nextPictureBox = (XanderUI.XUICustomPictureBox)ParentForm.Controls.Find(nextPageName + "_pbox", false)[0];
            nextPictureBox.Image = Properties.Resources.current;

            Label currentLabel = (Label)ParentForm.Controls.Find(currentPageName + "_label", false)[0];
            currentLabel.ForeColor = Color.LimeGreen;

            Panel nextLine = (Panel)ParentForm.Controls.Find(currentPageName + "_step", false)[0];
            nextLine.BackColor = Color.LimeGreen;

            ParentForm.Controls.Find("panel3", false)[0].Controls.Find(nextPageName, false)[0].BringToFront();
        }

        public void Exit(Form ParentForm)
        {
            ParentForm.Close();
        }
    }
}
