using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestRedactor.Logics
{
    class Precision
    {
        // Повысить резкость/размыть 
        public static uint[,] Filtration(uint[,] pixel, double[,] matrix)
        {
            int H = pixel.GetLength(0);
            int W = pixel.GetLength(1);
            int tmpH = H + 2, tmpW = W + 2;
            uint[,] tmppixel = new uint[tmpH, tmpW];
            uint[,] newpixel = new uint[H, W];
            //заполнение временного расширенного изображения
            //углы
            tmppixel[0, 0] = pixel[0, 0];
            tmppixel[0, tmpW - 1] = pixel[0, W - 1];
            tmppixel[tmpH - 1, 0] = pixel[H - 1, 0];
            tmppixel[tmpH - 1, tmpW - 1] = pixel[H - 1, W - 1];
            //крайние левая и правая стороны
            for (int i = 1; i < tmpH - 1; i++)
            {
                tmppixel[i, 0] = pixel[i - 1, 0];
                tmppixel[i, tmpW - 1] = pixel[i - 1, W - 1];
            }
            //крайние верхняя и нижняя стороны
            for (int j = 1; j < tmpW - 1; j++)
            {
                tmppixel[0, j] = pixel[0, j - 1];
                tmppixel[tmpH - 1, j] = pixel[H - 1, j - 1];
            }
            //центр
            for (int i = 0; i < H; i++)
                for (int j = 0; j < W; j++)
                    tmppixel[i + 1, j + 1] = pixel[i, j];
            //применение ядра свертки
            PixelPoint ColorOfPixel = new PixelPoint();
            PixelPoint ColorOfCell = new PixelPoint();
            for (int i = 1; i < tmpH - 1; i++)
                for (int j = 1; j < tmpW - 1; j++)
                {
                    ColorOfPixel.R = 0;
                    ColorOfPixel.G = 0;
                    ColorOfPixel.B = 0;
                    for (int k = 0; k < 3; k++)
                        for (int m = 0; m < 3; m++)
                        {
                            ColorOfCell = calculationOfColor(tmppixel[i - 1 + k, j - 1 + m], matrix[k, m]);
                            ColorOfPixel.R += ColorOfCell.R;
                            ColorOfPixel.G += ColorOfCell.G;
                            ColorOfPixel.B += ColorOfCell.B;
                        }


                    newpixel[i - 1, j - 1] = build(ColorOfPixel);
                }

            return newpixel;
        }

        //вычисление нового цвета
        public static PixelPoint calculationOfColor(UInt32 pixel, double coefficient)
        {
            PixelPoint Color = new PixelPoint();
            Color.R = (int)(coefficient * ((pixel & 0x00FF0000) >> 16));
            Color.G = (int)(coefficient * ((pixel & 0x0000FF00) >> 8));
            Color.B = (int)(coefficient * (pixel & 0x000000FF));
            return Color;
        }

        //сборка каналов
        public static UInt32 build(PixelPoint ColorOfPixel)
        {
            UInt32 Color;
            Color = 0xFF000000 | ((UInt32)ColorOfPixel.R << 16) | ((UInt32)ColorOfPixel.G << 8) | ((UInt32)ColorOfPixel.B);
            return Color;
        }


        
    }
}
