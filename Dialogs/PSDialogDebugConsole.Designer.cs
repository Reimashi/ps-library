namespace PSLibrary.Dialogs
{
    partial class PSDialogDebugConsole
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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.flButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.bClose = new System.Windows.Forms.Button();
            this.pPal = new System.Windows.Forms.Panel();
            this.flButtons.SuspendLayout();
            this.pPal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.Color.Black;
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.ForeColor = System.Drawing.Color.Lime;
            this.tbLog.Location = new System.Drawing.Point(12, 12);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(560, 299);
            this.tbLog.TabIndex = 0;
            // 
            // flButtons
            // 
            this.flButtons.Controls.Add(this.bClose);
            this.flButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flButtons.Location = new System.Drawing.Point(0, 323);
            this.flButtons.Name = "flButtons";
            this.flButtons.Padding = new System.Windows.Forms.Padding(5);
            this.flButtons.Size = new System.Drawing.Size(584, 39);
            this.flButtons.TabIndex = 1;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(496, 8);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "CLOSE";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // pPal
            // 
            this.pPal.Controls.Add(this.tbLog);
            this.pPal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPal.Location = new System.Drawing.Point(0, 0);
            this.pPal.Name = "pPal";
            this.pPal.Padding = new System.Windows.Forms.Padding(12);
            this.pPal.Size = new System.Drawing.Size(584, 323);
            this.pPal.TabIndex = 2;
            // 
            // PSDialogDebugConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pPal);
            this.Controls.Add(this.flButtons);
            this.Name = "PSDialogDebugConsole";
            this.Text = "PSDialogLogTextBox";
            this.flButtons.ResumeLayout(false);
            this.pPal.ResumeLayout(false);
            this.pPal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.FlowLayoutPanel flButtons;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Panel pPal;
    }
}