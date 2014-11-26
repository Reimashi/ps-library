namespace PSLibrary.Dialogs.Updater
{
    partial class CheckUpdate
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
            this.pTitulo = new System.Windows.Forms.Panel();
            this.lInfo = new System.Windows.Forms.Label();
            this.pBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lDescription = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbState = new System.Windows.Forms.PictureBox();
            this.line2 = new PSLibrary.Controls.Line();
            this.line1 = new PSLibrary.Controls.Line();
            this.pTitulo.SuspendLayout();
            this.pBotones.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.White;
            this.pTitulo.Controls.Add(this.lInfo);
            this.pTitulo.Controls.Add(this.pbState);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(437, 26);
            this.pTitulo.TabIndex = 0;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfo.Location = new System.Drawing.Point(11, 6);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(226, 16);
            this.lInfo.TabIndex = 0;
            this.lInfo.Text = "Información de la actualización.";
            // 
            // pBotones
            // 
            this.pBotones.Controls.Add(this.bCancel);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pBotones.Location = new System.Drawing.Point(0, 140);
            this.pBotones.Name = "pBotones";
            this.pBotones.Padding = new System.Windows.Forms.Padding(4);
            this.pBotones.Size = new System.Drawing.Size(437, 38);
            this.pBotones.TabIndex = 1;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(351, 7);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cerrar";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Controls.Add(this.lDescription);
            this.pPrincipal.Controls.Add(this.progressBar1);
            this.pPrincipal.Controls.Add(this.line2);
            this.pPrincipal.Controls.Add(this.line1);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 26);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(437, 114);
            this.pPrincipal.TabIndex = 2;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(28, 62);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(180, 15);
            this.lDescription.TabIndex = 4;
            this.lDescription.Text = "Descripción de la actualización.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(413, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // pbState
            // 
            this.pbState.Image = global::PSLibrary.Properties.Resources.loadingIcon32;
            this.pbState.Location = new System.Drawing.Point(413, 2);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(24, 24);
            this.pbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbState.TabIndex = 3;
            this.pbState.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.line2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line2.Location = new System.Drawing.Point(0, 113);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(437, 1);
            this.line2.TabIndex = 1;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line1.Dock = System.Windows.Forms.DockStyle.Top;
            this.line1.Location = new System.Drawing.Point(0, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(437, 1);
            this.line1.TabIndex = 0;
            // 
            // CheckUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 178);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckUpdate";
            this.Text = "CheckUpdate";
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pBotones.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.FlowLayoutPanel pBotones;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Panel pPrincipal;
        private Controls.Line line1;
        private Controls.Line line2;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.PictureBox pbState;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}