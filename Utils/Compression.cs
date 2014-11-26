using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SevenZip.Compression.LZMA;
using System.IO;

namespace PSLibrary.Utils.Compression
{
    /// <summary>
    /// Libreria para la compresión LZMA (Aún no es usable)
    /// </summary>
    public static class LZMA
    {
        public static void CompressFileLZMA(string inFile, string outFile)
        {
            SevenZip.Compression.LZMA.Encoder coder = new SevenZip.Compression.LZMA.Encoder();

            using (FileStream input = new FileStream(inFile, FileMode.Open))
            {
                using (FileStream output = new FileStream(outFile, FileMode.Create))
                {
                    coder.Code(input, output, -1, -1, null);
                    output.Flush();
                }
            }
        }
    }
}
