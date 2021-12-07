using System;
using System.Drawing;

namespace BestRedactor.Logics
{
    public static class ColorBalance
    {
        // Цветовой баланс
        public static Bitmap RgbBalance(Bitmap image, int r, int g, int b)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            r -= 99;
            g -= 99;
            b -= 99;
            var rgb   = new PixelPoint();
            var total = (Bitmap)image.Clone();

            Color c;

            for (var y = 0; y < total.Height; y++)
            for (var x = 0; x < total.Width; x++)
            {
                c     = total.GetPixel(x, y);
                if (c.A != 0)
                {
                    rgb.R = c.R + r * 128 / 100;
                    rgb.G = c.G + g * 128 / 100;
                    rgb.B = c.B + b * 128 / 100;
                    total.SetPixel(x, y, Color.FromArgb(255, rgb.R, rgb.G, rgb.B));
                }
            }

            return total;
        }
        
        
        // Чернобелый фильтр 
        public static Bitmap ToGrayScale(Bitmap image)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            Color c;
            var   total = (Bitmap)image.Clone();

            for (var y = 0; y < total.Height; y++)
            for (var x = 0; x < total.Width; x++)
            {
                c = total.GetPixel(x, y);
                if (c.A != 0)
                {
                    int rgb = (int) Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    total.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            }

            return total;
        }
        
        
        // Инвертирова цвета
        public static Bitmap IverseColor(Bitmap image)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            var total = (Bitmap)image.Clone();

            for (var y = 0; y <= total.Height - 1; y++)
            for (var x = 0; x <= total.Width - 1; x++)
            {
                var inv = total.GetPixel(x, y);
                if (inv.A != 0)
                {
                    inv = Color.FromArgb(255, 255 - inv.R, 255 - inv.G, 255 - inv.B);
                    total.SetPixel(x, y, inv);
                }
            }

            return total;
        }
        
        
        // Сепия
        public static Bitmap Sepia(Bitmap image)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            var rgb   = new PixelPoint();
            var total = (Bitmap)image.Clone();

            for (var i = 0; i < total.Width; i++)
            for (var j = 0; j < total.Height; j++)
            {
                var temp = total.GetPixel(i, j);
                if (temp.A != 0)
                {
                    rgb.R = (int) (temp.R * 0.393f + temp.G * 0.769f + temp.B * 0.189f);
                    rgb.G = (int) (temp.R * 0.349f + temp.G * 0.686f + temp.B * 0.168f);
                    rgb.B = (int) (temp.R * 0.272f + temp.G * 0.534f + temp.B * 0.131f);

                    total.SetPixel(i, j, Color.FromArgb(255, rgb.R, rgb.G, rgb.B));
                }
            }

            return total;
        }
    }
}