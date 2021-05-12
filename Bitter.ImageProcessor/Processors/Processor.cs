using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitter.ImageProcessor.Processors
{
    public class Processor
    {
        public Processor()
        {

        }

        public static Bitmap GrayScale(Bitmap source)
        {
            Bitmap copied = new Bitmap(source);

            for (int i = 0; i < copied.Width; i++)
            {
                for (int j = 0; j < copied.Height; j++)
                {
                    Color color = copied.GetPixel(i, j);

                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    //regular math
                    int gray = (byte)(.299 * R + .587 * G + .114 * B);

                    R = gray;
                    G = gray;
                    B = gray;

                    copied.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return copied;
        }

        public static Bitmap ColorScale(Bitmap source, byte red, byte green, byte blue)
        {
            Bitmap copied = new Bitmap(source);

            for (int i = 0; i < copied.Width; i++)
            {
                for (int j = 0; j < copied.Height; j++)
                {
                    Color color = copied.GetPixel(i, j);
                    var A = color.A;
                    int R = (byte)red;
                    int G = (byte)green;
                    int B = (byte)blue;

                    var brightness = color.GetBrightness();

                    var r2 = .299 * R;
                    var g2 = .587 * G;
                    var b2 = .114 * B;
                    //regular math
                    int gray = (byte)(r2 + g2 + b2);

                    R = gray;
                    G = gray;
                    B = gray;

                    copied.SetPixel(i, j, Color.FromArgb(A, red, green, blue));
                   
                }
            }

            return copied;
        }

        public static Bitmap GrayScaleUnsafe(Bitmap source)
        {
            unsafe
            {
                //create an empty bitmap the same size as original
                Bitmap newBitmap = new Bitmap(source.Width, source.Height);

                //lock the original bitmap in memory
                BitmapData originalData = source.LockBits(
                   new Rectangle(0, 0, source.Width, source.Height),
                   ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

                //lock the new bitmap in memory
                BitmapData newData = newBitmap.LockBits(
                   new Rectangle(0, 0, source.Width, source.Height),
                   ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

                //set the number of bytes per pixel
                int pixelSize = 3;

                for (int y = 0; y < source.Height; y++)
                {
                    //get the data from the original image
                    byte* oRow = (byte*)originalData.Scan0 + (y * originalData.Stride);

                    //get the data from the new image
                    byte* nRow = (byte*)newData.Scan0 + (y * newData.Stride);

                    for (int x = 0; x < source.Width; x++)
                    {
                        //create the grayscale version
                        byte grayScale =
                           (byte)((oRow[x * pixelSize] * .11) + //B
                           (oRow[x * pixelSize + 1] * .59) +  //G
                           (oRow[x * pixelSize + 2] * .3)); //R

                        //set the new image's pixel to the grayscale version
                        nRow[x * pixelSize] = grayScale; //B
                        nRow[x * pixelSize + 1] = grayScale; //G
                        nRow[x * pixelSize + 2] = grayScale; //R
                    }
                }

                //unlock the bitmaps
                newBitmap.UnlockBits(newData);
                source.UnlockBits(originalData);

                return newBitmap;
            }
        }

        public static Bitmap GrayScaleMatrix(Bitmap source)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(source.Width, source.Height);

            //get a graphics object from the new image
            Graphics graphics = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                   new float[] {.3f, .3f, .3f, 0, 0},
                   new float[] {.59f, .59f, .59f, 0, 0},
                   new float[] {.11f, .11f, .11f, 0, 0},
                   new float[] {0, 0, 0, 1, 0},
                   new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            graphics.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height),
               0, 0, source.Width, source.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            graphics.Dispose();
            return newBitmap;
        }

        public static Bitmap RedScaleUnsafe(Bitmap source, int red)
        {
            unsafe
            {
                //create an empty bitmap the same size as original
                Bitmap newBitmap = new Bitmap(source.Width, source.Height);

                //lock the original bitmap in memory
                BitmapData originalData = source.LockBits(
                   new Rectangle(0, 0, source.Width, source.Height),
                   ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

                //lock the new bitmap in memory
                BitmapData newData = newBitmap.LockBits(
                   new Rectangle(0, 0, source.Width, source.Height),
                   ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

                //set the number of bytes per pixel
                int pixelSize = 3;

                for (int y = 0; y < source.Height; y++)
                {
                    //get the data from the original image
                    byte* oRow = (byte*)originalData.Scan0 + (y * originalData.Stride);

                    //get the data from the new image
                    byte* nRow = (byte*)newData.Scan0 + (y * newData.Stride);

                    for (int x = 0; x < source.Width; x++)
                    {
                        //create the grayscale version
                        byte grayScale =
                           (byte)((oRow[x * pixelSize] * .11) + //B
                           (oRow[x * pixelSize + 1] * .59) +  //G
                           (oRow[x * pixelSize + 2] * .3)); //R

                        //set the new image's pixel to the grayscale version
                        nRow[x * pixelSize] = grayScale; //B
                        nRow[x * pixelSize + 1] = grayScale; //G
                        nRow[x * pixelSize + 2] = (byte)red; //R
                    }
                }

                //unlock the bitmaps
                newBitmap.UnlockBits(newData);
                source.UnlockBits(originalData);

                return newBitmap;
            }
        }

        public static Bitmap ColorScaleUnsafe(Bitmap source, int red, int green, int blue)
        {
            unsafe
            {
                //create an empty bitmap the same size as original
                Bitmap newBitmap = new Bitmap(source.Width, source.Height);

                //lock the original bitmap in memory
                BitmapData originalData = source.LockBits(
                   new Rectangle(0, 0, source.Width, source.Height),
                   ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

                //lock the new bitmap in memory
                BitmapData newData = newBitmap.LockBits(
                   new Rectangle(0, 0, source.Width, source.Height),
                   ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

                //set the number of bytes per pixel
                int pixelSize = 3;

                for (int y = 0; y < source.Height; y++)
                {
                    //get the data from the original image
                    byte* oRow = (byte*)originalData.Scan0 + (y * originalData.Stride);

                    //get the data from the new image
                    byte* nRow = (byte*)newData.Scan0 + (y * newData.Stride);

                    for (int x = 0; x < source.Width; x++)
                    {
                        //create the grayscale version
                        byte grayScale =
                           (byte)((oRow[x * pixelSize] * .11) + //B
                           (oRow[x * pixelSize + 1] * .59) +  //G
                           (oRow[x * pixelSize + 2] * .3)); //R

                        //(byte)(.238 * r2 + .16 * g2 + .16 * b2);
                        byte redScale =
                          (byte)((oRow[x * pixelSize] * .16) + //B
                          (oRow[x * pixelSize + 1] * .16) +  //G
                          (oRow[x * pixelSize + 2] * .238)); //R
                        
                        //set the new image's pixel to the grayscale version
                        nRow[x * pixelSize] = grayScale; //B
                        nRow[x * pixelSize + 1] = grayScale; //G
                        nRow[x * pixelSize + 2] = grayScale; //R
                    }
                }

                //unlock the bitmaps
                newBitmap.UnlockBits(newData);
                source.UnlockBits(originalData);

                return newBitmap;
            }
        }
    }
}
