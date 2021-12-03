using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestRedactor.Interface;



namespace BestRedactor.Logics
{
    class Intensity
    {
        //якрость
        public static IPicture Brightness(IPicture image, int poz, int lenght)
        {
            int N = (100 / lenght) * poz; //кол-во процентов
            PixelPoint rgb = new PixelPoint();
            Color c;

            for (int y = 0; y < image.Bitmap.Height; y++)
                for (int x = 0; x < image.Bitmap.Width; x++)
                {
                    c = image.Bitmap.GetPixel(x, y);
                    rgb.R = (c.R + N * 128 / 100);
                    rgb.G = (c.B + N * 128 / 100);
                    rgb.B = (c.G + N * 128 / 100);
                    image.Bitmap.SetPixel(x, y, Color.FromArgb(rgb.R, rgb.G, rgb.B));
                }
            return image;
        }

        //контрастность
        public static IPicture Contrast(IPicture image, int poz, int lenght)
        {
            int N = 20;//(100 / lenght) * (poz - 101); //кол-во процентов
            PixelPoint rgb = new PixelPoint();
            Color c;

            for (int y = 0; y < image.Bitmap.Height; y++)
                for (int x = 0; x < image.Bitmap.Width; x++)
                {
                    c = image.Bitmap.GetPixel(x, y);
                    if (N >= 0)
                    {
                        if (N == 100) N = 99;
                        rgb.R = (c.R * 100 - 128 * N) / (100 - N);
                        rgb.G = (c.B * 100 - 128 * N) / (100 - N);
                        rgb.B = (c.G * 100 - 128 * N) / (100 - N);
                    }
                    else
                    {
                        rgb.R = (c.R * (100 + N) - 128 * N) / 100;
                        rgb.G = (c.B * (100 + N) - 128 * N) / 100;
                        rgb.B = (c.G * (100 + N) - 128 * N) / 100;
                        
                    }
                    image.Bitmap.SetPixel(x, y, Color.FromArgb(rgb.R, rgb.G, rgb.B));
                }
            return image;
        }
    }
}
