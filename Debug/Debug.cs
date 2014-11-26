using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PSLibrary.Debug
{
    public static class Debug
    {
        private static PSLibrary.Dialogs.PSDialogDebugConsole gui = new PSLibrary.Dialogs.PSDialogDebugConsole("Debbug Console", false);
        private static Boolean filelog_use = false;
        private static FileStream filelog;
        private static StreamWriter writer;

        public static void AddInformative(String text)
        {
            gui.AddLine("INFO => " + text);
            PrintToArchive("INFO => " + text);
        }

        public static void AddWarning(String text)
        {
            gui.AddLine("WARNING => " + text);
            PrintToArchive("WARNING => " + text);
        }

        public static void AddError(String text)
        {
            gui.AddLine("ERROR => " + text);
            PrintToArchive("ERROR => " + text);
        }

        private static void PrintToArchive(String text)
        {
            if (filelog_use)
            {
                if (filelog == null)
                {
                    filelog = new FileStream("log.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    writer = new StreamWriter(filelog);
                }

                writer.WriteLine(DateTime.Now.Date.ToShortDateString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + " => " + text);
            }
        }

        public static void Close()
        {
            if (filelog != null)
            {
                try
                {
                    writer.Close();
                    filelog.Close();
                }
                catch { }
            }
        }

        public static Boolean ShowGUI
        {
            get { return gui.DEBUG; }
            set { gui.DEBUG = value; }
        }

        public static Boolean ShowFile
        {
            get { return filelog_use; }
            set { filelog_use = value; }
        }

        public static String FileLog
        {
            get
            {
                if (filelog != null)
                    return filelog.Name;
                else
                    return String.Empty;
            }
        }

        public static String GUITitle
        {
            get { return gui.Text; }
            set { gui.Text = value; }
        }
    }
}
