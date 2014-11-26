using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSLibrary.G11N;

namespace PSLibrary.Dialogs
{
    public partial class PSDialogDebugConsole : Form
    {
        private Boolean debug;

        public PSDialogDebugConsole(String title, Boolean debugActive)
        {
            InitializeComponent();

            this.Icon = Properties.Resources.bug;

            this.debug = debugActive;

            this.Text = title;
            this.bClose.Text = g11n.getTranslateString("Close");
        }

        public void AddLine(String line)
        {
            try
            {
                this.tbLog.Text += line + Environment.NewLine;
                ShowIfHide();
            }
            catch { }
        }

        public String TEXT
        {
            get { return this.tbLog.Text; }
            set 
            { 
                try
                {
                    this.tbLog.Text = value;
                }
                catch { }
            }
        }

        public Boolean DEBUG
        {
            get { return this.debug; }
            set { this.debug = value; }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowIfHide()
        {
            if (!debug)
                return;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(PSDialogDebugConsole))
                {
                    return;
                }
            }

            this.Show();
        }
    }
}
