using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSLibrary.Utils.IO
{
    public static class DirectoryInfo
    {
        /// <summary>
        /// Calcula el tamaño de los archivos de una carpeta y sus subdirectorios
        /// </summary>
        /// <param name="folder">Ruta de la carpeta</param>
        /// <returns>Tamaño en bytes de la carpeta</returns>
        public static UInt64 CalculateFolderSize(string folder)
        {
            UInt64 folderSize = 0;
            try
            {
                //Checks if the path is valid or not 
                if (!System.IO.Directory.Exists(folder))
                    return folderSize;
                else
                {
                    try
                    {
                        foreach (string file in System.IO.Directory.GetFiles(folder))
                        {
                            if (System.IO.File.Exists(file))
                            {
                                System.IO.FileInfo finfo = new System.IO.FileInfo(file);
                                folderSize += System.Convert.ToUInt64(finfo.Length);
                            }
                        }
                        foreach (string dir in System.IO.Directory.GetDirectories(folder))
                            folderSize += CalculateFolderSize(dir);
                    }
                    catch (NotSupportedException e)
                    {
                        Console.WriteLine("Unable to calculate folder size: {0}", e.Message);
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unable to calculate folder size: {0}", e.Message);
            }
            return folderSize;
        }
    }
}
