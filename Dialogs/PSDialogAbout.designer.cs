namespace PSLibrary.Dialogs
{
    partial class DialogAbout
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
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.lAppName = new System.Windows.Forms.Label();
            this.lCopyright = new System.Windows.Forms.Label();
            this.lLink = new System.Windows.Forms.LinkLabel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.lVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logoImage.Location = new System.Drawing.Point(102, 12);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(80, 80);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // lAppName
            // 
            this.lAppName.AutoSize = true;
            this.lAppName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAppName.Location = new System.Drawing.Point(77, 95);
            this.lAppName.Name = "lAppName";
            this.lAppName.Size = new System.Drawing.Size(133, 35);
            this.lAppName.TabIndex = 1;
            this.lAppName.Text = "APPNAME";
            // 
            // lCopyright
            // 
            this.lCopyright.AutoSize = true;
            this.lCopyright.Location = new System.Drawing.Point(112, 241);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(51, 13);
            this.lCopyright.TabIndex = 2;
            this.lCopyright.Text = "Copyright";
            // 
            // lLink
            // 
            this.lLink.AutoSize = true;
            this.lLink.Location = new System.Drawing.Point(124, 264);
            this.lLink.Name = "lLink";
            this.lLink.Size = new System.Drawing.Size(27, 13);
            this.lLink.TabIndex = 3;
            this.lLink.TabStop = true;
            this.lLink.Text = "Link";
            this.lLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLink_LinkClicked);
            // 
            // tbDescription
            // 
            this.tbDescription.Enabled = false;
            this.tbDescription.Location = new System.Drawing.Point(12, 133);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(260, 96);
            this.tbDescription.TabIndex = 4;
            this.tbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(197, 295);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Cerrar";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lVersion.Location = new System.Drawing.Point(9, 308);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(42, 13);
            this.lVersion.TabIndex = 6;
            this.lVersion.Text = "Version";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 330);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lLink);
            this.Controls.Add(this.lCopyright);
            this.Controls.Add(this.lAppName);
            this.Controls.Add(this.logoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label lAppName;
        private System.Windows.Forms.Label lCopyright;
        private System.Windows.Forms.LinkLabel lLink;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lVersion;
    }
}