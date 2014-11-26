using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSLibrary.Dialogs
{
    public partial class PSDialogPopUpMessage : Form
    {
        /// <summary>
        /// Dialogo Pop-Up.
        /// </summary>
        /// <param name="message">Mensaje a mostrar.</param>
        /// <param name="timeout">Tiempo de espera para cerrar el dialogo.</param>
        public PSDialogPopUpMessage(String message, Int32 timeout)
        {
            InitializeComponent();

            this.lMessage.Text = message;

            this.lMessage.Bounds = new Rectangle(((this.Width / 2) - (this.lMessage.Width / 2)), ((this.Height / 2) - (this.lMessage.Height / 2)), this.lMessage.Width, this.lMessage.Height);

            if (timeout > 0)
            {
                tMessage.Interval = timeout;
                tMessage.Start();
            }
            else
                tMessage.Stop();
        }

        private void tMessage_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
