namespace PSLibrary.Apps
{
    partial class RSSReader
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tvRss = new System.Windows.Forms.TreeView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbUpdate = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(3, 3);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(26, 26);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bAdd);
            this.flowLayoutPanel1.Controls.Add(this.bDel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(68, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(35, 3);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(26, 26);
            this.bDel.TabIndex = 1;
            this.bDel.Text = "-";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 29);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbURL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(68, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.panel2.Size = new System.Drawing.Size(437, 29);
            this.panel2.TabIndex = 6;
            // 
            // tbURL
            // 
            this.tbURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbURL.Location = new System.Drawing.Point(5, 7);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(427, 20);
            this.tbURL.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bUpdate);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(505, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(34, 29);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // bUpdate
            // 
            this.bUpdate.BackgroundImage = global::PSLibrary.Properties.Resources.updateIcon32;
            this.bUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bUpdate.Location = new System.Drawing.Point(4, 3);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(26, 26);
            this.bUpdate.TabIndex = 0;
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(539, 331);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.tvRss);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 323);
            this.panel4.TabIndex = 0;
            // 
            // tvRss
            // 
            this.tvRss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvRss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRss.HideSelection = false;
            this.tvRss.Location = new System.Drawing.Point(0, 0);
            this.tvRss.Name = "tvRss";
            this.tvRss.Size = new System.Drawing.Size(531, 309);
            this.tvRss.TabIndex = 3;
            this.tvRss.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRss_AfterSelect);
            this.tvRss.DoubleClick += new System.EventHandler(this.tvRss_DoubleClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.pbUpdate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 309);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.panel5.Size = new System.Drawing.Size(531, 14);
            this.panel5.TabIndex = 2;
            // 
            // pbUpdate
            // 
            this.pbUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUpdate.Location = new System.Drawing.Point(0, 2);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(531, 10);
            this.pbUpdate.TabIndex = 1;
            // 
            // RSSReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "RSSReader";
            this.Size = new System.Drawing.Size(539, 360);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TreeView tvRss;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar pbUpdate;
        private System.Windows.Forms.Button bDel;

    }
}
