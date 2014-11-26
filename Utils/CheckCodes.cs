using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PSLibrary.Utils.CheckCodes
{
    /// <summary>
    /// Clase que realiza operaciones relacionadas con la validación de los códigos del DNI
    /// </summary>
    public static class DNI
    {
        ///<summary> Obtiene la letra de un DNI a partir del numero. </summary>
        ///<param name="dni"> String de 8 numeros que representan un DNI. </param>
        ///<returns> Letra del DNI. Si el numero es incorrecto o no tiene 8 caracteres devolverá el caracter nulo. </returns>
        public static Char GetLetter(String dni)
        {
            string Letters = "TRWAGMYFPDXBNJZSQVHLCKE";

            if (dni.Length == 8)
            {
                if (new Regex("[0-9]{8}").Match(dni).Success)
                {
                    return Letters[System.Convert.ToInt32((System.Convert.ToInt64(dni.Substring(0, 8)) % 23))];
                }
            }

            return '\0';
        }
    }

    public static class EMAIL
    {
        public static Boolean IsValidEmail(string email)
        {
            //regular expression pattern for valid email
            //addresses, allows for the following domains:
            //com,edu,info,gov,int,mil,net,org,biz,name,museum,coop,aero,pro,tv
            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.(com|es|gl|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";
            //Regular expression object
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            //boolean variable to return to calling method
            bool valid = false;

            //make sure an email address was provided
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                //use IsMatch to validate the address
                valid = check.IsMatch(email);
            }
            //return the value to the calling method
            return valid;
        }
    }
}
