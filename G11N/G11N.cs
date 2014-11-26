using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSLibrary.G11N
{
    /// <summary>
    /// Libreria de Internacionalización y localización. NO IMPLEMENTADA.
    /// </summary>
    static public class g11n
    {
        /// <summary>
        /// Evento que se dispara si ocurre un error durante la carga de un fichero de idiomas.
        /// </summary>
        public static event EventHandler languageLoadError;

        /// <summary>
        /// Countries Code List (ISO 3166:1993)
        /// </summary>
        public enum Countries {AF, AL, DZ, AS, AD, AO, AI, AQ, AG, AR, AM, AW, AU, AT, AZ, ZR, ZM, ZW,
                BS, BH, BD, BB, BE, BZ, BJ, BM, BT, BO, BA, BW, BV, BR, IO, VG, BN, BG, BF, BI,
                BY, KH, CM, CA, CV, KY, CF, TD, CL, CN, CX, CC, CO, KM, CG, CK, CR, CI, HR, CU,
                CY, CZ, KP, DK, DJ, DM, DO, TP, EC, EG, SV, GQ, ER, EE, ET, FK, FO, DE, FJ, FI, 
                FR, FX, GF, PF, TF, GA, GM, GE, GH, GI, GR, GL, GD, GP, GU, GT, GN, GW, GY, HT, 
                HM, HN, HK, HU, IS, IN, ID, IR, IQ, IE, IL, IT, JM, JP, JO, KZ, KE, KI, KW, KG, 
                LA, LV, LB, LS, LR, LY, LI, LT, LU, MO, MG, MW, MY, MV, ML, MT, MH, MQ, MR, MU, 
                YT, MX, FM, MD, MC, MN, MS, MA, MZ, MM, NA, NR, NP, NL, AN, NC, NZ, NI, NE, NG, 
                NU, NF, MP, NO, OM, PK, PW, PA, PG, PY, PE, PH, PN, PL, PT, PR, QA, KR, RE, RO, 
                RU, RW, KN, LC, WS, SM, ST, SA, SN, SC, SL, SG, SK, SI, SB, SO, ZA, GS, ES, LK,
                SH, PM, VC, SD, SR, SJ, SZ, SE, CH, SY, TW, TJ, TH, TG, TK, TO, TT, TN, TR, TM, 
                TC, TV, UG, UA, AE, GB, TZ, US, UM, VI, UY, UZ, VU, VA, VE, VN, WF, EH, YE, YU, UNDEFINED };

        /// <summary>
        /// Languages Code List (ISO 639-1)
        /// </summary>
        public enum Languages {AB, AF, AN, AR, AS, AZ, BE, BG, BN, BO, BR, BS, CA, CE, CO, CS, CU, CY, DA,
                DE, EL, EN, EO, ES, ET, EU, FA, FI, FJ, FO, FR, FY, GA, GD, GL, GV, HE, HI, HR, HT, 
                HU, HY, ID, IS, IT, JA, JV, KA, KG, KO, KU, KW, KY, LA, LB, LI, LN, LT, LV, MG, MK, 
                MN, MO, MS, MT, MY, NB, NE, NL, NN, NO, OC, PL, PT, RM, RO, RU, SC, SE, SK, SL, SO, 
                SQ, SR, SV, SW, TK, TR, TY, UK, UR, UZ, VI, VO, YI, ZH};

        static private Boolean isInited = false;

        static private Languages defaultLanguage;
        static private Countries defaultCountry;

        static private Languages currentLanguage;
        static private Countries currentCountry;

        static private G11N.Language actualLang;

        static public Boolean Init()
        {
            defaultLanguage = Languages.EN;
            defaultCountry = Countries.US;
            currentLanguage = defaultLanguage;
            currentCountry = defaultCountry;

            isInited = LoadLanguage();

            return isInited;
        }

        static public Boolean Init(Languages lang, Countries country)
        {
            defaultLanguage = lang;
            defaultCountry = country;
            currentLanguage = defaultLanguage;
            currentCountry = defaultCountry;

            isInited = LoadLanguage();

            return isInited;
        }

        static public String getTranslateString (String original)
        {
            if (!isInited)
                return original;
            else
            {
                return actualLang.getTranslateString(original);
            }
        }

        static public Boolean LoadLanguage()
        {
            // Si el idioma es el original del programa no es necesario inicializar nada
            if (currentLanguage == defaultLanguage && currentCountry == defaultCountry)
            {
                return false;
            }

            actualLang = new G11N.Language(currentLanguage, currentCountry);

            if (actualLang.Load())
                return true;
            else
            {
                actualLang = new G11N.Language(currentLanguage);

                if (actualLang.Load())
                    return true;
                else
                {
                    languageLoadError("Error while load xml language file", EventArgs.Empty);
                    return false;
                }
            }
        }

        static public Boolean ChangeLanguage(Languages lang)
        {
            currentLanguage = lang;
            isInited = LoadLanguage();
            return isInited;
        }

        static public Boolean ChangeLanguage(Languages lang, Countries country)
        {
            currentLanguage = lang;
            currentCountry = country;
            isInited = LoadLanguage();
            return isInited;
        }
    }
}
