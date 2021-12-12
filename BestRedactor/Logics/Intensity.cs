using System.Drawing;
using System;


namespace BestRedactor.Logics
{
    public static class Intensity
    {
        //яркость
        public static Bitmap Brightness(Bitmap image, int poz)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            var   n     = poz - 100; //кол-во процентов
            var   total = (Bitmap)image.Clone();
            var   rgb   = new PixelPoint();
            Color c;

            for (var y = 0; y < total.Height; y++)
            for (var x = 0; x < total.Width; x++)
            {
                c     = total.GetPixel(x, y);
                if (c.A == 0)
                    continue;
                rgb.R = c.R + n * 128 / 100;
                rgb.G = c.G + n * 128 / 100;
                rgb.B = c.B + n * 128 / 100;
                total.SetPixel(x, y, Color.FromArgb(rgb.R, rgb.G, rgb.B));
            }

            return total;
        }

        //контрастность
        public static Bitmap Contrast(Bitmap image, int poz)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            var n     = poz - 100; //кол-во процентов
            var rgb   = new PixelPoint();
            var total = (Bitmap)image.Clone();

            Color c;

            for (var y = 0; y < total.Height; y++)
            for (var x = 0; x < total.Width; x++)
            {
                c = total.GetPixel(x, y);
                if (c.A == 0)
                    continue;
                if (n >= 0)
                {
                    if (n == 100) n = 99;
                    rgb.R = (c.R * 100 - 128 * n) / (100 - n);
                    rgb.G = (c.G * 100 - 128 * n) / (100 - n);
                    rgb.B = (c.B * 100 - 128 * n) / (100 - n);
                }
                else
                {
                    rgb.R = (c.R * (100 + n) - 128 * n) / 100;
                    rgb.G = (c.G * (100 + n) - 128 * n) / 100;
                    rgb.B = (c.B * (100 + n) - 128 * n) / 100;
                }

                total.SetPixel(x, y, Color.FromArgb(rgb.R, rgb.G, rgb.B));
            }

            return total;
        }
    }
}