namespace Installer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.version_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eula_label = new System.Windows.Forms.Label();
            this.path_label = new System.Windows.Forms.Label();
            this.installing_label = new System.Windows.Forms.Label();
            this.finish_label = new System.Windows.Forms.Label();
            this.eula_pbox = new XanderUI.XUICustomPictureBox();
            this.finish_pbox = new XanderUI.XUICustomPictureBox();
            this.installing_pbox = new XanderUI.XUICustomPictureBox();
            this.path_pbox = new XanderUI.XUICustomPictureBox();
            this.eula_step = new System.Windows.Forms.Panel();
            this.installing_step = new System.Windows.Forms.Panel();
            this.path_step = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.BackColor = System.Drawing.Color.BlueViolet;
            this.version_label.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.version_label.ForeColor = System.Drawing.Color.White;
            this.version_label.Location = new System.Drawing.Point(3, 3);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(171, 14);
            this.version_label.TabIndex = 2;
            this.version_label.Text = "v%version% [%date%] %uuid%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "This is an Automated Installer\r\ncreated by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(105, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Da4ndo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 18.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Installing %name%";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.version_label);
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 23);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Installer.Properties.Resources.da4ndo_189x189;
            this.pictureBox1.Location = new System.Drawing.Point(58, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 179);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(329, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 385);
            this.panel3.TabIndex = 14;
            // 
            // eula_label
            // 
            this.eula_label.AutoSize = true;
            this.eula_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eula_label.Location = new System.Drawing.Point(342, 72);
            this.eula_label.Name = "eula_label";
            this.eula_label.Size = new System.Drawing.Size(34, 17);
            this.eula_label.TabIndex = 19;
            this.eula_label.Text = "Eula";
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.path_label.Location = new System.Drawing.Point(494, 72);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(35, 17);
            this.path_label.TabIndex = 20;
            this.path_label.Text = "Path";
            // 
            // installing_label
            // 
            this.installing_label.AutoSize = true;
            this.installing_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.installing_label.Location = new System.Drawing.Point(634, 72);
            this.installing_label.Name = "installing_label";
            this.installing_label.Size = new System.Drawing.Size(60, 17);
            this.installing_label.TabIndex = 21;
            this.installing_label.Text = "Installing";
            // 
            // finish_label
            // 
            this.finish_label.AutoSize = true;
            this.finish_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finish_label.Location = new System.Drawing.Point(791, 72);
            this.finish_label.Name = "finish_label";
            this.finish_label.Size = new System.Drawing.Size(42, 17);
            this.finish_label.TabIndex = 22;
            this.finish_label.Text = "Finish";
            // 
            // eula_pbox
            // 
            this.eula_pbox.Color1 = System.Drawing.Color.Transparent;
            this.eula_pbox.Color2 = System.Drawing.Color.Transparent;
            this.eula_pbox.FilterAlpha = 200;
            this.eula_pbox.FilterEnabled = false;
            this.eula_pbox.Image = global::Installer.Properties.Resources.current;
            this.eula_pbox.IsElipse = false;
            this.eula_pbox.IsParallax = false;
            this.eula_pbox.Location = new System.Drawing.Point(329, 9);
            this.eula_pbox.Name = "eula_pbox";
            this.eula_pbox.Size = new System.Drawing.Size(60, 60);
            this.eula_pbox.TabIndex = 23;
            this.eula_pbox.Text = "xuiCustomPictureBox1";
            // 
            // finish_pbox
            // 
            this.finish_pbox.Color1 = System.Drawing.Color.Transparent;
            this.finish_pbox.Color2 = System.Drawing.Color.Transparent;
            this.finish_pbox.FilterAlpha = 200;
            this.finish_pbox.FilterEnabled = false;
            this.finish_pbox.Image = global::Installer.Properties.Resources.pending;
            this.finish_pbox.IsElipse = false;
            this.finish_pbox.IsParallax = false;
            this.finish_pbox.Location = new System.Drawing.Point(782, 9);
            this.finish_pbox.Name = "finish_pbox";
            this.finish_pbox.Size = new System.Drawing.Size(60, 60);
            this.finish_pbox.TabIndex = 24;
            this.finish_pbox.Text = "xuiCustomPictureBox2";
            // 
            // installing_pbox
            // 
            this.installing_pbox.Color1 = System.Drawing.Color.Transparent;
            this.installing_pbox.Color2 = System.Drawing.Color.Transparent;
            this.installing_pbox.FilterAlpha = 200;
            this.installing_pbox.FilterEnabled = false;
            this.installing_pbox.Image = global::Installer.Properties.Resources.pending;
            this.installing_pbox.IsElipse = false;
            this.installing_pbox.IsParallax = false;
            this.installing_pbox.Location = new System.Drawing.Point(634, 9);
            this.installing_pbox.Name = "installing_pbox";
            this.installing_pbox.Size = new System.Drawing.Size(60, 60);
            this.installing_pbox.TabIndex = 25;
            this.installing_pbox.Text = "xuiCustomPictureBox3";
            // 
            // path_pbox
            // 
            this.path_pbox.Color1 = System.Drawing.Color.Transparent;
            this.path_pbox.Color2 = System.Drawing.Color.Transparent;
            this.path_pbox.FilterAlpha = 200;
            this.path_pbox.FilterEnabled = false;
            this.path_pbox.Image = global::Installer.Properties.Resources.pending;
            this.path_pbox.IsElipse = false;
            this.path_pbox.IsParallax = false;
            this.path_pbox.Location = new System.Drawing.Point(481, 9);
            this.path_pbox.Name = "path_pbox";
            this.path_pbox.Size = new System.Drawing.Size(60, 60);
            this.path_pbox.TabIndex = 26;
            this.path_pbox.Text = "xuiCustomPictureBox4";
            // 
            // eula_step
            // 
            this.eula_step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eula_step.Location = new System.Drawing.Point(384, 37);
            this.eula_step.Name = "eula_step";
            this.eula_step.Size = new System.Drawing.Size(100, 5);
            this.eula_step.TabIndex = 27;
            // 
            // installing_step
            // 
            this.installing_step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.installing_step.Location = new System.Drawing.Point(691, 37);
            this.installing_step.Name = "installing_step";
            this.installing_step.Size = new System.Drawing.Size(100, 5);
            this.installing_step.TabIndex = 28;
            // 
            // path_step
            // 
            this.path_step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.path_step.Location = new System.Drawing.Point(538, 37);
            this.path_step.Name = "path_step";
            this.path_step.Size = new System.Drawing.Size(100, 5);
            this.path_step.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(894, 534);
            this.Controls.Add(this.path_pbox);
            this.Controls.Add(this.installing_pbox);
            this.Controls.Add(this.finish_pbox);
            this.Controls.Add(this.eula_pbox);
            this.Controls.Add(this.finish_label);
            this.Controls.Add(this.installing_label);
            this.Controls.Add(this.path_label);
            this.Controls.Add(this.eula_label);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path_step);
            this.Controls.Add(this.eula_step);
            this.Controls.Add(this.installing_step);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Installer for %name%";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label eula_label;
        private System.Windows.Forms.Label path_label;
        private System.Windows.Forms.Label installing_label;
        private System.Windows.Forms.Label finish_label;
        private XanderUI.XUICustomPictureBox eula_pbox;
        private XanderUI.XUICustomPictureBox finish_pbox;
        private XanderUI.XUICustomPictureBox installing_pbox;
        private XanderUI.XUICustomPictureBox path_pbox;
        private System.Windows.Forms.Panel eula_step;
        private System.Windows.Forms.Panel installing_step;
        private System.Windows.Forms.Panel path_step;
    }
}

