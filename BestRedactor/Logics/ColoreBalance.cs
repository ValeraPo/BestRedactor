using BestRedactor.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestRedactor.Logics
{
    public class ColorBalance
    {
        // Цветовой баланс
        public static Bitmap RgbBalance(Bitmap image, int r, int g, int b)
        {
            r -= 99;
            g -= 99;
            b -= 99;
            PixelPoint rgb = new PixelPoint();
            Bitmap total = (Bitmap)image.Clone();

            Color c;

            for (int y = 0; y < total.Height; y++)
            for (int x = 0; x < total.Width; x++)
            {
                c = total.GetPixel(x, y);
                rgb.R = c.R + r * 128 / 100;
                rgb.G = c.G + g * 128 / 100;
                rgb.B = c.B + b * 128 / 100;
                total.SetPixel(x, y, Color.FromArgb(255, rgb.R, rgb.G, rgb.B));
            }
            return total;
        }
        // Чернобелый фильтр 
        public static Bitmap ToGrayScale(Bitmap image)
        {
            int rgb;
            Color c;
            Bitmap total = (Bitmap)image.Clone();

            for (int y = 0; y < total.Height; y++)
                for (int x = 0; x < total.Width; x++)
                {
                    c = total.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    total.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return total;
        }
        // Инвертирова цвета
        public static Bitmap IverseColor(Bitmap image)
        {
            Bitmap total = (Bitmap)image.Clone();

            for (int y = 0; (y <= (total.Height - 1)); y++)
            {
                for (int x = 0; (x <= (total.Width - 1)); x++)
                {
                    Color inv = total.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    total.SetPixel(x, y, inv);
                }
            }
            return total;
        }
        // Сепия
        public static Bitmap Sepia(Bitmap image)
        {
            float p = 10;
            PixelPoint rgb = new PixelPoint();
            Bitmap total = (Bitmap)image.Clone();
            int i = 0,
                j = 0,
                h = total.Height,
                w = total.Width;

            for (i = 0; i < w; i++)
            {
                for (j = 0; j < h; j++)
                {
                    Color temp = total.GetPixel(i, j);
                    rgb.R = (int) ((temp.R * 0.393f) + (temp.R * 0.769f) + (temp.R * 0.189f));
                    rgb.G = (int) ((temp.G * 0.349f) + (temp.G * 0.686f) + (temp.G * 0.168f));
                    rgb.B = (int) ((temp.B * 0.272f) + (temp.B * 0.534f) + (temp.B * 0.131f));

                    total.SetPixel(i, j, Color.FromArgb(255, rgb.R, rgb.G, rgb.B));
                }
            }
            return total;
        }
    }
}
