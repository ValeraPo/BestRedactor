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
        public static Bitmap Brightness(Bitmap image, int poz)
        {
            int N = poz - 99; //кол-во процентов
            Bitmap total = (Bitmap)image.Clone();
            PixelPoint rgb = new PixelPoint();
            Color c;

            for (int y = 0; y < total.Height; y++)
                for (int x = 0; x < total.Width; x++)
                {
                    c = total.GetPixel(x, y);
                    rgb.R = (c.R + N * 128 / 100);
                    rgb.G = (c.G + N * 128 / 100);
                    rgb.B = (c.B + N * 128 / 100);
                    total.SetPixel(x, y, Color.FromArgb(rgb.R, rgb.G, rgb.B));
                }
            
            
            return total;
        }

        //контрастность
        public static Bitmap Contrast(Bitmap image, int poz)
        {
            int N = poz - 99; //кол-во процентов
            PixelPoint rgb = new PixelPoint();
            Bitmap total = (Bitmap)image.Clone();

            Color c;

            for (int y = 0; y < total.Height; y++)
                for (int x = 0; x < total.Width; x++)
                {
                    c = total.GetPixel(x, y);
                    if (N >= 0)
                    {
                        if (N == 100) N = 99;
                        rgb.R = (c.R * 100 - 128 * N) / (100 - N);
                        rgb.G = (c.G * 100 - 128 * N) / (100 - N);
                        rgb.B = (c.B * 100 - 128 * N) / (100 - N);
                    }
                    else
                    {
                        rgb.R = (c.R * (100 + N) - 128 * N) / 100;
                        rgb.G = (c.G * (100 + N) - 128 * N) / 100;
                        rgb.B = (c.B * (100 + N) - 128 * N) / 100;
                        
                    }
                    total.SetPixel(x, y, Color.FromArgb(rgb.R, rgb.G, rgb.B));
                }
            return total;
        }
    }
}
