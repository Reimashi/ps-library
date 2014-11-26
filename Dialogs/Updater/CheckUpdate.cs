using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSLibrary.Dialogs.Updater
{
    public partial class CheckUpdate : Form
    {
        public CheckUpdate()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            // Cerrar
            this.Close();
        }
    }
}
