using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using PSLibrary;

namespace PSLibrary.Utils.Image
{
    static public class Operations
    {
        ///<summary> Redimensiona una imagen. </summary>
        ///<param name="image"> Imagen original. </param>
        ///<param name="width"> Nueva resolución a lo ancho en pixeles. </param>
        ///<param name="height"> Nueva resolución a lo alto en pixeles. </param>
        /// <returns> Bitmap con la imagen redimensionada. </returns>
        public static Bitmap Resize(Bitmap image, int width, int height)
        {
            // Se crea un nuevo bitmap con el tamaño final que le queremos asignar
            Bitmap imagenBitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            imagenBitmap.SetResolution(Convert.ToInt32(image.HorizontalResolution), Convert.ToInt32(image.HorizontalResolution));

            // Se crea una zona de dibujado para el Bitmap
            Graphics imagenGraphics = Graphics.FromImage(imagenBitmap);

            // Se establecen los parametros para la conversion
            imagenGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            imagenGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            imagenGraphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            // Se dibuja la nueva imagen
            imagenGraphics.DrawImage(image, new Rectangle(0, 0, width, height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            return imagenBitmap;
        }

        ///<summary> Recorta una imagen. </summary>
        ///<param name="image"> Imagen original. </param>
        ///<param name="cordx"> Coordenada en X a partir de donde se recortará. </param>
        ///<param name="cordy"> Coordenada en Y a partir de donde se recortará. </param>
        ///<param name="width"> Ancho (px) de la sección a recortar. </param>
        ///<param name="heigth"> Alto (px) de la sección a recortar. </param>
        /// <returns> Bitmap con la imagen recortada. </returns>
        public static Bitmap Cut(Bitmap image, int cordx, int cordy, int width, int heigth)
        {
            // Se crea un nuevo bitmap con el tamaño final que le queremos asignar
            Bitmap imagenBitmap = new Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            imagenBitmap.SetResolution(Convert.ToInt32(image.HorizontalResolution), Convert.ToInt32(image.HorizontalResolution));

            // Se crea una zona de dibujado para el Bitmap
            Graphics imagenGraphics = Graphics.FromImage(imagenBitmap);

            // Se establecen los parametros para la conversion
            imagenGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            imagenGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            imagenGraphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            // Se dibuja la nueva imagen
            imagenGraphics.DrawImage(image, new Rectangle(0, 0, width, heigth), new Rectangle(cordx, cordy, width, heigth), GraphicsUnit.Pixel);

            return imagenBitmap;
        }
    }
}
