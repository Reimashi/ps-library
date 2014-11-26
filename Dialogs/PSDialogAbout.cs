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
    ///<summary> Un dialogo de "Acerca de..." sencillo (GTK-Style). </summary>
    public partial class DialogAbout : Form
    {
        private String appname;
        private String version;
        private String title;
        private String copyright;
        private String link_name;
        private Uri link;

        ///<summary> Un dialogo de "Acerca de..." sencillo (GTK-Style). </summary>
        ///<param name="title"> Titulo de la ventana. Quedara: "{title} - Acerca de..." </param>
        ///<param name="appname"> Nombre de la aplicación. </param>
        ///<param name="version"> Versión de la aplicación. </param>
        ///<param name="description"> Descripción de la aplicación. </param>
        ///<param name="copyright"> Copyright o licencia a la que se acoje. </param>
        ///<param name="linkname"> Nombre del editor o de la web del editor. </param>
        ///<param name="link"> Dirección URL de la web del editor de la aplicación. </param>
        ///<param name="image"> Imagen o icono de la aplicación. Se aconseja de 80x80 px. </param>
        ///<param name="icon"> Objeto Icon con el icono a mostrar en la ventana. </param>
        public DialogAbout(String title, String appname, String version, String description, String copyright, String linkname, Uri link, Bitmap image, Icon icon)
        {
            InitializeComponent();

            TITLE = title;
            APPNAME = appname;
            VERSION = version;
            COPYRIGHT = copyright;
            LINK_NAME = linkname;
            this.link = link;

            if (title != null && title != "")
                this.Text = title + " - " + g11n.getTranslateString("About");
            else
                this.Text = g11n.getTranslateString("About");

            this.bClose.Text = g11n.getTranslateString("Close");

            this.logoImage.Image = image;

            this.lAppName.Text = this.appname;
            this.lAppName.SetBounds( (this.Width / 2) - (this.lAppName.Width / 2), this.lAppName.Bounds.Y, this.lAppName.Width, this.lAppName.Height );

            this.tbDescription.Text = description;

            this.lCopyright.Text = this.copyright;
            this.lCopyright.SetBounds((this.Width / 2) - (this.lCopyright.Width / 2), this.lCopyright.Bounds.Y, this.lCopyright.Width, this.lCopyright.Height);

            this.lLink.Text = this.link_name;
            this.lLink.SetBounds((this.Width / 2) - (this.lLink.Width / 2), this.lLink.Bounds.Y, this.lLink.Width, this.lLink.Height);

            this.lVersion.Text = this.version;

            this.Icon = icon;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String APPNAME
        {
            set
            {
                if ( value.Length > 20 )
                {
                    this.appname = value.Substring(0, 20);
                }
                else 
                {
                    this.appname = value;
                }
            }
        }

        private String TITLE
        {
            set
            {
                if (value.Length > 20)
                {
                    this.title = value.Substring(0, 20);
                }
                else
                {
                    this.title = value;
                }
            }
        }

        private String VERSION
        {
            set
            {
                if (value.Length > 12)
                {
                    this.version = value.Substring(0, 12);
                }
                else
                {
                    this.version = value;
                }
            }
        }

        private String COPYRIGHT
        {
            set
            {
                if ( value.Length > 45 )
                {
                    this.copyright = value.Substring(0, 45);
                }
                else 
                {
                    this.copyright = value;
                }
            }
        }

        private String LINK_NAME
        {
            set
            {
                if ( value.Length > 45 )
                {
                    this.link_name = value.Substring(0, 45);
                }
                else 
                {
                    this.link_name = value;
                }
            }
        }

        private void lLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link.ToString());
        }
    }
}
