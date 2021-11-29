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
        public static void R(IPicture image, int poz, int lenght)
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
        }

        //цветовой баланс G
        public static void G(IPicture image, int poz, int lenght)
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
        }

        //цветовой баланс B
        public static void B(IPicture image, int poz, int lenght)
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
        }
        // Чернобелый фильтр 
        public void ToGrayScale(IPicture image)
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
        }

    }
}
