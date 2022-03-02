namespace Installer.Panels
{
    partial class path
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cpath_button = new XanderUI.XUISuperButton();
            this.pathlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.path_next_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpath_button
            // 
            this.cpath_button.BackgroundColor = System.Drawing.Color.Transparent;
            this.cpath_button.ButtonImage = global::Installer.Properties.Resources.folder;
            this.cpath_button.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.cpath_button.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.cpath_button.ButtonText = "";
            this.cpath_button.CornerRadius = 5;
            this.cpath_button.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.cpath_button.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.cpath_button.HoverTextColor = System.Drawing.Color.White;
            this.cpath_button.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.cpath_button.Location = new System.Drawing.Point(371, 126);
            this.cpath_button.Name = "cpath_button";
            this.cpath_button.SelectedBackColor = System.Drawing.Color.Transparent;
            this.cpath_button.SelectedTextColor = System.Drawing.Color.White;
            this.cpath_button.Size = new System.Drawing.Size(25, 26);
            this.cpath_button.SuperSelected = false;
            this.cpath_button.TabIndex = 18;
            this.cpath_button.TextColor = System.Drawing.Color.White;
            this.cpath_button.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.cpath_button.Click += new System.EventHandler(this.cpath_button_Click);
            // 
            // pathlabel
            // 
            this.pathlabel.AutoSize = true;
            this.pathlabel.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathlabel.Location = new System.Drawing.Point(100, 129);
            this.pathlabel.Name = "pathlabel";
            this.pathlabel.Size = new System.Drawing.Size(47, 19);
            this.pathlabel.TabIndex = 17;
            this.pathlabel.Text = "Path:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(145, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // path_next_button
            // 
            this.path_next_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.path_next_button.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.path_next_button.FlatAppearance.BorderSize = 0;
            this.path_next_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.path_next_button.Location = new System.Drawing.Point(416, 353);
            this.path_next_button.Name = "path_next_button";
            this.path_next_button.Size = new System.Drawing.Size(75, 29);
            this.path_next_button.TabIndex = 15;
            this.path_next_button.Text = "Next";
            this.path_next_button.UseVisualStyleBackColor = false;
            this.path_next_button.Click += new System.EventHandler(this.path_next_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_button.Location = new System.Drawing.Point(18, 353);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 29);
            this.back_button.TabIndex = 19;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "The software will be installed in the folder listed below. To \r\ninstall to a diff" +
    "erent doler, either type in a new path, or click \r\nbutton wuth File icon to brow" +
    "se for an existing folder.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(77, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Space required on drive:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(77, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Space available on selected drive:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(345, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "%size%";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.Location = new System.Drawing.Point(345, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "%size%";
            // 
            // path
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.cpath_button);
            this.Controls.Add(this.pathlabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.path_next_button);
            this.Name = "path";
            this.Size = new System.Drawing.Size(513, 385);
            this.Load += new System.EventHandler(this.path_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUISuperButton cpath_button;
        private System.Windows.Forms.Label pathlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button path_next_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
