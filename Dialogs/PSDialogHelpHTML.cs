using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PSLibrary.G11N;

namespace PSLibrary.Dialogs
{
    ///<summary> Un dialogo de ayuda que muestra un archivo HTML. </summary>
    public partial class DialogHelpHTML : Form
    {
        private Uri helpURL;
        private String publisherURL;

        ///<summary> Un dialogo de ayuda que muestra un archivo HTML. </summary>
        ///<param name="title"> Titulo de la ventana. Quedara: "{title} - Ayuda" </param>
        ///<param name="helpURL"> Dirección fisica relativa del documento de ayuda a mostrar. Ejemplo: "help.html" o "data/help/index.html" </param>
        ///<param name="publisherURL"> Dirección URL de la web del editor de la aplicación. </param>
        ///<param name="icon"> Objeto Icon con el icono a mostrar en la ventana. </param>
        public DialogHelpHTML(String title, String helpURL, String publisherURL, Icon icon)
        {
            InitializeComponent();

            this.Icon = icon;
            this.lLink.Text = publisherURL;
            if (title.Length < 1)
                this.Text = title + " - " + g11n.getTranslateString("Help");
            else
                this.Text = g11n.getTranslateString("Help");

            this.publisherURL = publisherURL;
            this.lLink.Text = g11n.getTranslateString("Publisher Webpage");

            this.bCerrar.Text = g11n.getTranslateString("Close");

            try
            {
                this.helpURL = new Uri(Directory.GetCurrentDirectory() + '/' + helpURL);
            }
            catch
            {
                MessageBox.Show(g11n.getTranslateString("Help file not found."), g11n.getTranslateString("Help - Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                this.helpBrowser.Navigate(this.helpURL);
            }
            catch
            {
                MessageBox.Show(g11n.getTranslateString("Failed to open the help file."), g11n.getTranslateString("Help - Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.publisherURL);
        }
    }
}
