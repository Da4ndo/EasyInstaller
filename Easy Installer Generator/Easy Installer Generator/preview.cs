using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Easy_Installer_Generator
{
    public partial class preview : Form
    {
        public preview()
        {
            _previewof = "Unknown";
            InitializeComponent();
        }

        public preview(string previewof, string image_path)
        {
            _previewof = "Unknown";
            InitializeComponent();
            _previewof = previewof;
            if (Directory.Exists(image_path))
                imgfiles = Directory.GetFiles(@image_path);
        }

        private string _previewof { get; set; }
        private string[] imgfiles = { };
        private int current_loaded = 0;


        private void preview_Load(object sender, EventArgs e)
        {
            Location = new Point(Application.OpenForms[0].Location.X + 600, Application.OpenForms[0].Location.Y - 70);
            label1.Text = $"Preview of {_previewof}";
            Text = $"Preview of {_previewof}";
            label1.Location = new Point(((Width - label1.Width) / 2), 9);
            label2.Location = new Point(((Width - label2.Width) / 2), 186);

            if (imgfiles.Length == 0 || imgfiles == new string[] { })
                label2.Visible = true;
            else
            {
                pictureBox1.Image = new Bitmap(imgfiles[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imgfiles.Length - 1 > current_loaded)
            {
                current_loaded++;
                pictureBox1.Image = new Bitmap(imgfiles[current_loaded]);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (0 < current_loaded)
            {
                current_loaded--;
                pictureBox1.Image = new Bitmap(imgfiles[current_loaded]);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            PreviewClass.previews[_previewof] = false;
        }
    }
}
