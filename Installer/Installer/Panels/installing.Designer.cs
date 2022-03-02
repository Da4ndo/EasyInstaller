namespace Installer.Panels
{
    partial class installing
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
            this.progressBar = new XanderUI.XUICircleProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.install_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.AnimationSpeed = 5;
            this.progressBar.FilledColor = System.Drawing.Color.LimeGreen;
            this.progressBar.FilledColorAlpha = 130;
            this.progressBar.FilledThickness = 40;
            this.progressBar.IsAnimated = false;
            this.progressBar.Location = new System.Drawing.Point(155, 44);
            this.progressBar.Name = "progressBar";
            this.progressBar.Percentage = 0;
            this.progressBar.ShowText = true;
            this.progressBar.Size = new System.Drawing.Size(200, 200);
            this.progressBar.TabIndex = 20;
            this.progressBar.TextColor = System.Drawing.Color.Gray;
            this.progressBar.TextSize = 25;
            this.progressBar.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.progressBar.UnfilledThickness = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(190, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Downloading files...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(205, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Size: %size%";
            // 
            // install_button
            // 
            this.install_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.install_button.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.install_button.FlatAppearance.BorderSize = 0;
            this.install_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.install_button.Location = new System.Drawing.Point(416, 353);
            this.install_button.Name = "install_button";
            this.install_button.Size = new System.Drawing.Size(75, 29);
            this.install_button.TabIndex = 16;
            this.install_button.Text = "Install";
            this.install_button.UseVisualStyleBackColor = false;
            this.install_button.Click += new System.EventHandler(this.install_button_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
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
            this.back_button.TabIndex = 21;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // installing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.install_button);
            this.Name = "installing";
            this.Size = new System.Drawing.Size(513, 385);
            this.Load += new System.EventHandler(this.installing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICircleProgressBar progressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button install_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button back_button;
    }
}
