using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSLibrary.Utils.EventReply
{
    /// <summary>
    /// Clase de respuestas para eventos. Eventos KeyPress.
    /// </summary>
    public static class KeyPress_EventReply
    {
        /// <summary>
        /// Esta clase responde al evento Keypress solo permitiendo el paso a teclas de caracteres.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Esta clase responde al evento Keypress solo permitiendo el paso a teclas numericos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
