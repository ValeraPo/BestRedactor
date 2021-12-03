using BestRedactor.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestRedactor.Logics
{
    class Precision
    {
        //Размыть 
        public static IPicture Blur(IPicture image, int poz, int lenght)
        {
            int kSize = (10 / lenght) *poz; //кол-во процентов
            if (kSize % 2 == 0) kSize++;
            Bitmap Hblur = (Bitmap)image.Bitmap.Clone();
            float Avg = (float)1 / kSize;

            for (int j = 0; j < image.Bitmap.Height; j++)
            {

                float[] hSum = new float[] { 0f, 0f, 0f, 0f };
                float[] iAvg = new float[] { 0f, 0f, 0f, 0f };

                for (int x = 0; x < kSize; x++)
                {
                    Color tmpColor = image.Bitmap.GetPixel(x, j);
                    hSum[0] += tmpColor.A;
                    hSum[1] += tmpColor.R;
                    hSum[2] += tmpColor.G;
                    hSum[3] += tmpColor.B;
                }
                iAvg[0] = hSum[0] * Avg;
                iAvg[1] = hSum[1] * Avg;
                iAvg[2] = hSum[2] * Avg;
                iAvg[3] = hSum[3] * Avg;
                for (int i = 0; i < image.Bitmap.Width; i++)
                {
                    if (i - kSize / 2 >= 0 && i + 1 + kSize / 2 < image.Bitmap.Width)
                    {
                        Color tmp_pColor = image.Bitmap.GetPixel(i - kSize / 2, j);
                        hSum[0] -= tmp_pColor.A;
                        hSum[1] -= tmp_pColor.R;
                        hSum[2] -= tmp_pColor.G;
                        hSum[3] -= tmp_pColor.B;
                        Color tmp_nColor = image.Bitmap.GetPixel(i + 1 + kSize / 2, j);
                        hSum[0] += tmp_nColor.A;
                        hSum[1] += tmp_nColor.R;
                        hSum[2] += tmp_nColor.G;
                        hSum[3] += tmp_nColor.B;
                        //
                        iAvg[0] = hSum[0] * Avg;
                        iAvg[1] = hSum[1] * Avg;
                        iAvg[2] = hSum[2] * Avg;
                        iAvg[3] = hSum[3] * Avg;
                    }
                    Hblur.SetPixel(i, j, Color.FromArgb((int)iAvg[0], (int)iAvg[1], (int)iAvg[2], (int)iAvg[3]));
                }
            }
            Bitmap total = (Bitmap)Hblur.Clone();
            for (int i = 0; i < Hblur.Width; i++)
            {
                float[] tSum = new float[] { 0f, 0f, 0f, 0f };
                float[] iAvg = new float[] { 0f, 0f, 0f, 0f };
                for (int y = 0; y < kSize; y++)
                {
                    Color tmpColor = Hblur.GetPixel(i, y);
                    tSum[0] += tmpColor.A;
                    tSum[1] += tmpColor.R;
                    tSum[2] += tmpColor.G;
                    tSum[3] += tmpColor.B;
                }
                iAvg[0] = tSum[0] * Avg;
                iAvg[1] = tSum[1] * Avg;
                iAvg[2] = tSum[2] * Avg;
                iAvg[3] = tSum[3] * Avg;

                for (int j = 0; j < Hblur.Height; j++)
                {
                    if (j - kSize / 2 >= 0 && j + 1 + kSize / 2 < Hblur.Height)
                    {
                        Color tmp_pColor = Hblur.GetPixel(i, j - kSize / 2);
                        tSum[0] -= tmp_pColor.A;
                        tSum[1] -= tmp_pColor.R;
                        tSum[2] -= tmp_pColor.G;
                        tSum[3] -= tmp_pColor.B;
                        Color tmp_nColor = Hblur.GetPixel(i, j + 1 + kSize / 2);
                        tSum[0] += tmp_nColor.A;
                        tSum[1] += tmp_nColor.R;
                        tSum[2] += tmp_nColor.G;
                        tSum[3] += tmp_nColor.B;
                        //
                        iAvg[0] = tSum[0] * Avg;
                        iAvg[1] = tSum[1] * Avg;
                        iAvg[2] = tSum[2] * Avg;
                        iAvg[3] = tSum[3] * Avg;
                    }
                    image.Bitmap.SetPixel(i, j, Color.FromArgb((int)iAvg[0], (int)iAvg[1], (int)iAvg[2], (int)iAvg[3]));
                }
            }
            return image;
        }
        // Повысить резкость/размыть 
        public static IPicture Sharpness(IPicture image)
        {
            Bitmap sharpenImage = (Bitmap)image.Bitmap.Clone();

            int width = image.Bitmap.Width;
            int height = image.Bitmap.Height;

            // Create sharpening filter.
            double[,] filter = new double[,] { { -1, -1, -1, },
                                              { -1, 9, -1 },
                                              {-1, -1, -1, } };
            
            double factor = 1.0;
            double bias = 0.0;

            Color[,] result = new Color[image.Bitmap.Width, image.Bitmap.Height];

            // Lock image bits for read/write.
            BitmapData pbits = sharpenImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            // Declare an array to hold the bytes of the bitmap.
            int bytes = pbits.Stride * height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(pbits.Scan0, rgbValues, 0, bytes);

            int rgb;
            // Fill the color array with the new sharpened color values.
            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;

                    for (int filterX = 0; filterX < 3; filterX++)
                    {
                        for (int filterY = 0; filterY < 3; filterY++)
                        {
                            int imageX = (x - 3 / 2 + filterX + width) % width;
                            int imageY = (y - 3 / 2 + filterY + height) % height;

                            rgb = imageY * pbits.Stride + 3 * imageX;

                            red += rgbValues[rgb + 2] * filter[filterX, filterY];
                            green += rgbValues[rgb + 1] * filter[filterX, filterY];
                            blue += rgbValues[rgb + 0] * filter[filterX, filterY];
                        }
                        int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                        int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                        int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);

                        result[x, y] = Color.FromArgb(r, g, b);
                    }
                }
            }

            // Update the image with the sharpened pixels.
            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    rgb = y * pbits.Stride + 3 * x;

                    rgbValues[rgb + 2] = result[x, y].R;
                    rgbValues[rgb + 1] = result[x, y].G;
                    rgbValues[rgb + 0] = result[x, y].B;
                }
            }

            // Copy the RGB values back to the bitmap.
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, pbits.Scan0, bytes);
            // Release image bits.
            sharpenImage.UnlockBits(pbits);
            image.Bitmap = sharpenImage;
            return image;
        }
        
        // Добавить шум
        public static IPicture Noise(IPicture image)
        {
            float p = 10;
            int adjust = (int)(p * 2.55f);
            Random rand = new Random(adjust);
            int temprand = 0;
            PixelPoint rgb = new PixelPoint();

            int i = 0, j = 0,
                h = image.Bitmap.Height,
                w = image.Bitmap.Width;

            for (i = 0; i < w; i++)
            {
                for (j = 0; j < h; j++)
                {
                    Color temp = image.Bitmap.GetPixel(i, j);
                    rgb.R = temp.R; rgb.G = temp.G; rgb.B = temp.B; 

                    temprand = rand.Next(adjust * -1, adjust);

                    rgb.R += temprand;
                    rgb.G += temprand;
                    rgb.B += temprand;

                    image.Bitmap.SetPixel(i, j, Color.FromArgb(255, rgb.R, rgb.G, rgb.B));
                }
            }

            return image;
        }


    }
}
