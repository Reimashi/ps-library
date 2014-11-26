namespace PSLibrary.Dialogs
{
    partial class PSDialogPopUpMessage
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
            this.components = new System.ComponentModel.Container();
            this.lMessage = new System.Windows.Forms.Label();
            this.tMessage = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(85, 18);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(50, 13);
            this.lMessage.TabIndex = 0;
            this.lMessage.Text = "Message";
            // 
            // tMessage
            // 
            this.tMessage.Tick += new System.EventHandler(this.tMessage_Tick);
            // 
            // PSDialogPopUpMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 49);
            this.ControlBox = false;
            this.Controls.Add(this.lMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PSDialogPopUpMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSDialogPopUpMessage";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Timer tMessage;
    }
}