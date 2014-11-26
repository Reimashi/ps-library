using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace PSLibrary.G11N
{
    public class Language
    {
        private PSLibrary.G11N.g11n.Languages language;
        private PSLibrary.G11N.g11n.Countries country;

        private List<String> originalString = new List<string>();
        private List<String> translateString = new List<string>();

        public Language(PSLibrary.G11N.g11n.Languages lang)
        {
            Init(lang, PSLibrary.G11N.g11n.Countries.UNDEFINED);
        }

        public Language(PSLibrary.G11N.g11n.Languages lang, PSLibrary.G11N.g11n.Countries countr)
        {
            Init(lang, countr);
        }

        private void Init(PSLibrary.G11N.g11n.Languages lang, PSLibrary.G11N.g11n.Countries countr)
        {
            this.language = lang;
            this.country = countr;
        }

        public Boolean Load()
        {
            try
            {
                String fileName = Enum.GetName(typeof(PSLibrary.G11N.g11n.Languages), this.language);
                if (country != g11n.Countries.UNDEFINED)
                {
                    fileName += "_" + Enum.GetName(typeof(PSLibrary.G11N.g11n.Countries), this.country);
                }
                fileName += ".xml";

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("./lang/" + fileName);

                XmlNodeList ng11n = xDoc.GetElementsByTagName("g11n");

                XmlNodeList nLang = ((XmlElement)ng11n[0]).GetElementsByTagName("lang");
                XmlNodeList nCountry = ((XmlElement)ng11n[0]).GetElementsByTagName("country");
                // Hacer un chequeo de que el idioma es correcto

                XmlNodeList listaTraducciones = ((XmlElement)ng11n[0]).GetElementsByTagName("translatestring");

                foreach (XmlElement traduccion in listaTraducciones)
                {
                    XmlNodeList nOriginal = traduccion.GetElementsByTagName("original");

                    XmlNodeList nTraduccido = traduccion.GetElementsByTagName("translation");

                    this.originalString.Add(nOriginal[0].InnerText);
                    this.translateString.Add(nTraduccido[0].InnerText);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public String getTranslateString(String original)
        {
            for (Int32 i = 0; i < originalString.Count; i++)
            {
                if (original == originalString[i])
                {
                    return translateString[i];
                }
            }

            return original;
        }

        public PSLibrary.G11N.g11n.Languages LANGUAGE
        {
            get { return this.language; }
        }

        public PSLibrary.G11N.g11n.Countries COUNTRY
        {
            get { return this.country; }
        }
    }
}
