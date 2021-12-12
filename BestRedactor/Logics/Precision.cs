using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace BestRedactor.Logics
{
    class Precision
    {
        //Размыть 
        public static Bitmap Blur(Bitmap image)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            var kSize = 5; 
            var hblur = (Bitmap)image.Clone();
            var avg   = (float)1 / kSize;

            for (var j = 0; j < hblur.Height; j++)
            {
                var hSum = new[] { 0f, 0f, 0f, 0f };
                var iAvg = new[] { 0f, 0f, 0f, 0f };

                for (var x = 0; x < kSize; x++)
                {
                    var tmpColor = hblur.GetPixel(x, j);
                    hSum[0] += tmpColor.A;
                    hSum[1] += tmpColor.R;
                    hSum[2] += tmpColor.G;
                    hSum[3] += tmpColor.B;
                }

                iAvg[0] = hSum[0] * avg;
                iAvg[1] = hSum[1] * avg;
                iAvg[2] = hSum[2] * avg;
                iAvg[3] = hSum[3] * avg;
                for (var i = 0; i < hblur.Width; i++)
                {
                    if (i - kSize / 2 >= 0 && i + 1 + kSize / 2 < hblur.Width)
                    {
                        var tmpPColor = hblur.GetPixel(i - kSize / 2, j);
                        hSum[0] -= tmpPColor.A;
                        hSum[1] -= tmpPColor.R;
                        hSum[2] -= tmpPColor.G;
                        hSum[3] -= tmpPColor.B;
                        

                        var tmpNColor = hblur.GetPixel(i + 1 + kSize / 2, j);
                        hSum[0] += tmpNColor.A;
                        hSum[1] += tmpNColor.R;
                        hSum[2] += tmpNColor.G;
                        hSum[3] += tmpNColor.B;
                        //
                        iAvg[0] = hSum[0] * avg;
                        iAvg[1] = hSum[1] * avg;
                        iAvg[2] = hSum[2] * avg;
                        iAvg[3] = hSum[3] * avg;
                    }

                    hblur.SetPixel(i, j, Color.FromArgb((int)iAvg[0], (int)iAvg[1], (int)iAvg[2], (int)iAvg[3]));
                }
            }

            var total = (Bitmap)image.Clone();
            for (var i = 0; i < hblur.Width; i++)
            {
                var tSum = new[] { 0f, 0f, 0f, 0f };
                var iAvg = new[] { 0f, 0f, 0f, 0f };
                for (var y = 0; y < kSize; y++)
                {
                    var tmpColor = hblur.GetPixel(i, y);
                    tSum[0] += tmpColor.A;
                    tSum[1] += tmpColor.R;
                    tSum[2] += tmpColor.G;
                    tSum[3] += tmpColor.B;
                }

                iAvg[0] = tSum[0] * avg;
                iAvg[1] = tSum[1] * avg;
                iAvg[2] = tSum[2] * avg;
                iAvg[3] = tSum[3] * avg;

                for (var j = 0; j < hblur.Height; j++)
                {
                    if (j - kSize / 2 >= 0 && j + 1 + kSize / 2 < hblur.Height)
                    {
                        var tmpPColor = hblur.GetPixel(i, j - kSize / 2);
                        if (tmpPColor.A != 0)
                        {
                            tSum[0] -= tmpPColor.A;
                            tSum[1] -= tmpPColor.R;
                            tSum[2] -= tmpPColor.G;
                            tSum[3] -= tmpPColor.B;
                        }

                        var tmpNColor = hblur.GetPixel(i, j + 1 + kSize / 2);
                        tSum[0] += tmpNColor.A;
                        tSum[1] += tmpNColor.R;
                        tSum[2] += tmpNColor.G;
                        tSum[3] += tmpNColor.B;
                        //
                        iAvg[0] = tSum[0] * avg;
                        iAvg[1] = tSum[1] * avg;
                        iAvg[2] = tSum[2] * avg;
                        iAvg[3] = tSum[3] * avg;
                    }

                    total.SetPixel(i, j, Color.FromArgb((int)iAvg[0], (int)iAvg[1], (int)iAvg[2], (int)iAvg[3]));
                }
            }
            for (var y = 0; y < total.Height; y++)
            for (var x = 0; x < total.Width; x++)
            {
                if (image.GetPixel(x,y).A == 0)
                    total.SetPixel(x,y, image.GetPixel(x,y));
            }
            return total;
        }


        // Повысить резкость 
        public static Bitmap Sharpness(Bitmap image)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            var sharpenImage = (Bitmap)image.Clone();
            var width        = sharpenImage.Width;
            var height       = sharpenImage.Height;
            var filter = new double[,]
                         {
                             { -1, -1, -1 },
                             { -1, 9, -1 },
                             { -1, -1, -1 }
                         };

            const double factor = 1.0;
            const double bias   = 0.0;

            var result = new Color[sharpenImage.Width, sharpenImage.Height];

            var pbits = sharpenImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            var bytes     = pbits.Stride * height;
            var rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(pbits.Scan0, rgbValues, 0, bytes);

            int rgb;
            for (var x = 0; x < width; ++x)
            for (var y = 0; y < height; ++y)
            {
                double red = 0.0, green = 0.0, blue = 0.0;

                for (var filterX = 0; filterX < 3; filterX++)
                {
                    for (var filterY = 0; filterY < 3; filterY++)
                    {
                        var imageX = (x - 3 / 2 + filterX + width) % width;
                        var imageY = (y - 3 / 2 + filterY + height) % height;

                        rgb = imageY * pbits.Stride + 3 * imageX;

                        red   += rgbValues[rgb + 2] * filter[filterX, filterY];
                        green += rgbValues[rgb + 1] * filter[filterX, filterY];
                        blue  += rgbValues[rgb + 0] * filter[filterX, filterY];
                    }

                    var r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                    var g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                    var b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);
                    result[x, y] = Color.FromArgb(r, g, b);
                }
            }


            for (var x = 0; x < width; ++x)
            for (var y = 0; y < height; ++y)
            {
                rgb = y * pbits.Stride + 3 * x;

                rgbValues[rgb + 2] = result[x, y].R;
                rgbValues[rgb + 1] = result[x, y].G;
                rgbValues[rgb + 0] = result[x, y].B;
            }


            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, pbits.Scan0, bytes);
            sharpenImage.UnlockBits(pbits);
            for (var x = 0; x < width; ++x)
            for (var y = 0; y < height; ++y)
            {
                if (image.GetPixel(x,y).A == 0)
                    sharpenImage.SetPixel(x,y, image.GetPixel(x,y));
            }
            return sharpenImage;
        }

        
        // Добавить шум
        public static Bitmap Noise(Bitmap image)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            const float p      = 10;
            var         total  = (Bitmap)image.Clone();
            var         adjust = (int)(p * 2.55f);
            var         rand   = new Random(adjust);
            var         rgb    = new PixelPoint();

            for (var i = 0; i < total.Width; i++)
            for (var j = 0; j < total.Height; j++)
            {
                var temp = total.GetPixel(i, j);
                if (temp.A == 0)
                    total.SetPixel(i, j, temp);
                else
                {
                    rgb.R = temp.R;
                    rgb.G = temp.G;
                    rgb.B = temp.B;


                    var temprand = rand.Next(adjust * -1, adjust);

                    rgb.R += temprand;
                    rgb.G += temprand;
                    rgb.B += temprand;
                    total.SetPixel(i, j, Color.FromArgb(255, rgb.R, rgb.G, rgb.B));
                }
            }
            return total;
        }
    }
}