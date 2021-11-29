using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestRedactor.Interface;



namespace BestRedactor.Logics
{
    class Filters
    {

        //преобразование из  Bitmap to uint[,]
        public static uint[,] FromBitmapToPixel(IPicture image)
        {
            //получение матрицы с пикселями
            uint[,] pixel = new uint[image.Bitmap.Height, image.Bitmap.Width];
            for (int y = 0; y < image.Bitmap.Height; y++)
                for (int x = 0; x < image.Bitmap.Width; x++)
                    pixel[y, x] = (uint)(image.Bitmap.GetPixel(x, y).ToArgb());
            //заполнение матрицы пикселями
            for (int y = 0; y < image.Bitmap.Height; y++)
                for (int x = 0; x < image.Bitmap.Width; x++)
                    image.Bitmap.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
            return pixel;
        }

        //якрость
        public static uint[,] Brightness(IPicture image, int poz, int lenght)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            int N = (100 / lenght) * poz; //кол-во процентов
            for (int i = 0; i < image.Bitmap.Height; i++)
                for (int j = 0; j < image.Bitmap.Width; j++)
                {
                    PixelPoint pixelPoint = new PixelPoint();
                    uint point = pixel[i, j];
                    pixelPoint.R = (int)(((point & 0x00FF0000) >> 16) + N * 128 / 100);
                    pixelPoint.G = (int)(((point & 0x0000FF00) >> 8) + N * 128 / 100);
                    pixelPoint.B = (int)((point & 0x000000FF) + N * 128 / 100);

                    pixel[i, j] = point;
                }

            return pixel;
        }

        //контрастность
        public static uint[,] Contrast(IPicture image, int poz, int lenght)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            int N = (100 / lenght) * poz; //кол-во процентов
            for (int i = 0; i < image.Bitmap.Height; i++)
                for (int j = 0; j < image.Bitmap.Width; j++)
                {
                    PixelPoint pixelPoint = new PixelPoint();
                    uint point = pixel[i, j];
                    if (N >= 0)
                    {
                        if (N == 100) N = 99;
                        pixelPoint.R = (int)((((point & 0x00FF0000) >> 16) * 100 - 128 * N) / (100 - N));
                        pixelPoint.G = (int)((((point & 0x0000FF00) >> 8) * 100 - 128 * N) / (100 - N));
                        pixelPoint.B = (int)(((point & 0x000000FF) * 100 - 128 * N) / (100 - N));
                    }
                    else
                    {
                        pixelPoint.R = (int)((((point & 0x00FF0000) >> 16) * (100 - (-N)) + 128 * (-N)) / 100);
                        pixelPoint.G = (int)((((point & 0x0000FF00) >> 8) * (100 - (-N)) + 128 * (-N)) / 100);
                        pixelPoint.B = (int)(((point & 0x000000FF) * (100 - (-N)) + 128 * (-N)) / 100);
                    }


                    point = 0xFF000000 | ((uint)pixelPoint.R << 16) | ((uint)pixelPoint.G << 8) | ((uint)pixelPoint.B);
                    pixel[i, j] = point;
                }

            return pixel;
        }
        // Повысить резкость
        public static uint[,] UpSharpness(IPicture image)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            double[,] sharpness = new double[,] {{-1, -1, -1},
                                                 {-1,  9, -1},
                                                 {-1, -1, -1}};
            return Precision.Filtration(pixel, sharpness);
        }
        // Размыть
        public static uint[,] Blur(IPicture image)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            double[,] blur = new double[,] {{0.111, 0.111, 0.111},
                                            {0.111, 0.111, 0.111},
                                            {0.111, 0.111, 0.111}};
            return Precision.Filtration(pixel, blur);
        }
        // цветокор 
        public static uint[,] ColorBalance_R(IPicture image, int poz, int lenght)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            uint p;
            for (int i = 0; i < image.Bitmap.Height; i++)
                for (int j = 0; j < image.Bitmap.Width; j++)
                {
                    pixel[i, j] = ColorBalance.Change_R(pixel[i, j], poz, lenght);
                }
            return pixel;

        }
        public static uint[,] ColorBalance_G(IPicture image, int poz, int lenght)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            for (int i = 0; i < image.Bitmap.Height; i++)
                for (int j = 0; j < image.Bitmap.Width; j++)
                {
                    pixel[i, j] = ColorBalance.Change_G(pixel[i, j], poz, lenght);
                }
            return pixel;

        }
        public static uint[,] ColorBalance_B(IPicture image, int poz, int lenght)
        {
            uint[,] pixel = FromBitmapToPixel(image);
            for (int i = 0; i < image.Bitmap.Height; i++)
                for (int j = 0; j < image.Bitmap.Width; j++)
                {
                    pixel[i, j] = ColorBalance.Change_B(pixel[i, j], poz, lenght);
                }
            return pixel;
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
