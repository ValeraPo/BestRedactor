using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestRedactor.Logics
{
    class Filters
    {
        public static uint[,] pixel;

        //преобразование из  Bitmap to uint[,]
        public static uint[,] FromBitmapToPixel(Bitmap image)
        {
            //получение матрицы с пикселями
            uint[,] pixel = new uint[image.Height, image.Width];
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    pixel[y, x] = (uint)(image.GetPixel(x, y).ToArgb());
            //заполнение матрицы пикселями
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    image.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
            return pixel;
        }

        //якрость
        public static uint Brightness(uint point, int poz, int lenght)
        {
            PixelPoint pixel = new PixelPoint();


            int N = (100 / lenght) * poz; //кол-во процентов

            pixel.R = (int)(((point & 0x00FF0000) >> 16) + N * 128 / 100);
            pixel.G = (int)(((point & 0x0000FF00) >> 8) + N * 128 / 100);
            pixel.B = (int)((point & 0x000000FF) + N * 128 / 100);

           
            point = 0xFF000000 | ((uint)pixel.R << 16) | ((uint)pixel.G << 8) | ((uint)pixel.B);

            return point;
        }

        //контрастность
        public static uint Contrast(uint point, int poz, int lenght)
        {
            PixelPoint pixel = new PixelPoint();

            int N = (100 / lenght) * poz; //кол-во процентов

            if (N >= 0)
            {
                if (N == 100) N = 99;
                pixel.R = (int)((((point & 0x00FF0000) >> 16) * 100 - 128 * N) / (100 - N));
                pixel.G = (int)((((point & 0x0000FF00) >> 8) * 100 - 128 * N) / (100 - N));
                pixel.B = (int)(((point & 0x000000FF) * 100 - 128 * N) / (100 - N));
            }
            else
            {
                pixel.R = (int)((((point & 0x00FF0000) >> 16) * (100 - (-N)) + 128 * (-N)) / 100);
                pixel.G = (int)((((point & 0x0000FF00) >> 8) * (100 - (-N)) + 128 * (-N)) / 100);
                pixel.B = (int)(((point & 0x000000FF) * (100 - (-N)) + 128 * (-N)) / 100);
            }

            
            point = 0xFF000000 | ((uint)pixel.R << 16) | ((uint)pixel.G << 8) | ((uint)pixel.B);

            return point;
        }
        // Повысить резкость
        public static uint[,] UpSharpness(Bitmap image)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            double[,] sharpness = new double[,] {{-1, -1, -1},
                                                 {-1,  9, -1},
                                                 {-1, -1, -1}};
            return Precision.Filtration(pixel, sharpness);
        }
        // Размыть
        public static uint[,] Blur(Bitmap image)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            double[,] blur = new double[,] {{0.111, 0.111, 0.111},
                                            {0.111, 0.111, 0.111},
                                            {0.111, 0.111, 0.111}};
            return Precision.Filtration(pixel, blur);
        }


    }
}
