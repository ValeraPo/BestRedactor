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
        //цветовой баланс R
        public static IPicture R(IPicture image, int poz, int lenght)
        {
            int N = (100 / lenght) * poz; //кол-во процентов
            PixelPoint rgb = new PixelPoint();
            Color c;

            for (int y = 0; y < image.Bitmap.Height; y++)
                for (int x = 0; x < image.Bitmap.Width; x++)
                {
                    c = image.Bitmap.GetPixel(x, y);
                    rgb.R = c.R + N * 128 / 100;
                    image.Bitmap.SetPixel(x, y, Color.FromArgb(rgb.R, c.G, c.B));
                }
            return image;
        }

        //цветовой баланс G
        public static IPicture G(IPicture image, int poz, int lenght)
        {
            int N = (100 / lenght) * poz; //кол-во процентов
            PixelPoint rgb = new PixelPoint();
            Color c;

            for (int y = 0; y < image.Bitmap.Height; y++)
                for (int x = 0; x < image.Bitmap.Width; x++)
                {
                    c = image.Bitmap.GetPixel(x, y);
                    rgb.G = c.G + N * 128 / 100;
                    image.Bitmap.SetPixel(x, y, Color.FromArgb(c.R, rgb.R, c.B));
                }
            return image;
        }

        //цветовой баланс B
        public static IPicture B(IPicture image, int poz, int lenght)
        {
            int N = (100 / lenght) * poz; //кол-во процентов
            PixelPoint rgb = new PixelPoint();
            Color c;

            for (int y = 0; y < image.Bitmap.Height; y++)
                for (int x = 0; x < image.Bitmap.Width; x++)
                {
                    c = image.Bitmap.GetPixel(x, y);
                    rgb.B = c.B + N * 128 / 100;
                    image.Bitmap.SetPixel(x, y, Color.FromArgb(c.R, c.G, rgb.R));
                }
            return image;
        }
        // Чернобелый фильтр 
        public IPicture ToGrayScale(IPicture image)
        {
            int rgb;
            Color c;

            for (int y = 0; y < image.Bitmap.Height; y++)
                for (int x = 0; x < image.Bitmap.Width; x++)
                {
                    c = image.Bitmap.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    image.Bitmap.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return image;
        }
        // Инвертирова цвета
        public IPicture IverseColor(IPicture image)
        {
            for (int y = 0; (y <= (image.Bitmap.Height - 1)); y++)
            {
                for (int x = 0; (x <= (image.Bitmap.Width - 1)); x++)
                {
                    Color inv = image.Bitmap.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    image.Bitmap.SetPixel(x, y, inv);
                }
            }
            return image;
        }
        // Сепия
        public IPicture Sepia(IPicture image)
        {
            float p = 10;
            int step = (int) Math.Floor(255 / p);
            PixelPoint rgb = new PixelPoint();
            float cr = 0, cg = 0, cb = 0;
            int i = 0,
                j = 0,
                h = image.Bitmap.Height,
                w = image.Bitmap.Width;

            for (i = 0; i < w; i++)
            {
                for (j = 0; j < h; j++)
                {
                    Color temp = image.Bitmap.GetPixel(i, j);
                    rgb.R = temp.R;
                    rgb.G = temp.G;
                    rgb.B = temp.B;
                    float tcr = cr, tcg = cg, tcb = cb;
                    rgb.R = (int) ((tcr * 0.393f) + (tcg * 0.769f) + (tcb * 0.189f));
                    rgb.G = (int) ((tcr * 0.349f) + (tcg * 0.686f) + (tcb * 0.168f));
                    rgb.B = (int) ((tcr * 0.272f) + (tcg * 0.534f) + (tcb * 0.131f));

                    image.Bitmap.SetPixel(i, j, Color.FromArgb(255, rgb.R, rgb.G, rgb.B));
                }

            }
            return image;

        }
    }
}
