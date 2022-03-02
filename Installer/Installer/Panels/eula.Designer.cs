namespace Installer.Panels
{
    partial class eula
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
            this.accept_eula_button = new System.Windows.Forms.Button();
            this.eula_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accept_eula_button
            // 
            this.accept_eula_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accept_eula_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accept_eula_button.Location = new System.Drawing.Point(416, 353);
            this.accept_eula_button.Name = "accept_eula_button";
            this.accept_eula_button.Size = new System.Drawing.Size(75, 29);
            this.accept_eula_button.TabIndex = 2;
            this.accept_eula_button.Text = "Accept";
            this.accept_eula_button.UseVisualStyleBackColor = false;
            this.accept_eula_button.Click += new System.EventHandler(this.accept_eula_button_Click);
            // 
            // eula_textbox
            // 
            this.eula_textbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eula_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eula_textbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.eula_textbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eula_textbox.Location = new System.Drawing.Point(17, 0);
            this.eula_textbox.Multiline = true;
            this.eula_textbox.Name = "eula_textbox";
            this.eula_textbox.ReadOnly = true;
            this.eula_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eula_textbox.Size = new System.Drawing.Size(474, 332);
            this.eula_textbox.TabIndex = 3;
            // 
            // eula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accept_eula_button);
            this.Controls.Add(this.eula_textbox);
            this.Name = "eula";
            this.Size = new System.Drawing.Size(513, 385);
            this.Load += new System.EventHandler(this.eula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept_eula_button;
        private System.Windows.Forms.TextBox eula_textbox;
    }
}
