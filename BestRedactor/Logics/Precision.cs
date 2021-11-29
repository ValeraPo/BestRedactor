using BestRedactor.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestRedactor.Logics
{
    class Precision
    {
        //Размыть 
        public static void Blur(IPicture image, int poz, int lenght)
        {
            int kSize = (10 / lenght) *poz; //кол-во процентов
            if (kSize % 2 == 0) kSize++;
            Bitmap Hblur = (Bitmap)image.Bitmap.Clone();
            float Avg = (float)1 / kSize;

            for (int j = 0; j < image.Bitmap.Height; j++)
            {

                float[] hSum = new float[] { 0f, 0f, 0f, 0f };
                float[] iAvg = new float[] { 0f, 0f, 0f, 0f };

                for (int x = 0; x < kSize; x++)
                {
                    Color tmpColor = image.Bitmap.GetPixel(x, j);
                    hSum[0] += tmpColor.A;
                    hSum[1] += tmpColor.R;
                    hSum[2] += tmpColor.G;
                    hSum[3] += tmpColor.B;
                }
                iAvg[0] = hSum[0] * Avg;
                iAvg[1] = hSum[1] * Avg;
                iAvg[2] = hSum[2] * Avg;
                iAvg[3] = hSum[3] * Avg;
                for (int i = 0; i < image.Bitmap.Width; i++)
                {
                    if (i - kSize / 2 >= 0 && i + 1 + kSize / 2 < image.Bitmap.Width)
                    {
                        Color tmp_pColor = image.Bitmap.GetPixel(i - kSize / 2, j);
                        hSum[0] -= tmp_pColor.A;
                        hSum[1] -= tmp_pColor.R;
                        hSum[2] -= tmp_pColor.G;
                        hSum[3] -= tmp_pColor.B;
                        Color tmp_nColor = image.Bitmap.GetPixel(i + 1 + kSize / 2, j);
                        hSum[0] += tmp_nColor.A;
                        hSum[1] += tmp_nColor.R;
                        hSum[2] += tmp_nColor.G;
                        hSum[3] += tmp_nColor.B;
                        //
                        iAvg[0] = hSum[0] * Avg;
                        iAvg[1] = hSum[1] * Avg;
                        iAvg[2] = hSum[2] * Avg;
                        iAvg[3] = hSum[3] * Avg;
                    }
                    Hblur.SetPixel(i, j, Color.FromArgb((int)iAvg[0], (int)iAvg[1], (int)iAvg[2], (int)iAvg[3]));
                }
            }
            Bitmap total = (Bitmap)Hblur.Clone();
            for (int i = 0; i < Hblur.Width; i++)
            {
                float[] tSum = new float[] { 0f, 0f, 0f, 0f };
                float[] iAvg = new float[] { 0f, 0f, 0f, 0f };
                for (int y = 0; y < kSize; y++)
                {
                    Color tmpColor = Hblur.GetPixel(i, y);
                    tSum[0] += tmpColor.A;
                    tSum[1] += tmpColor.R;
                    tSum[2] += tmpColor.G;
                    tSum[3] += tmpColor.B;
                }
                iAvg[0] = tSum[0] * Avg;
                iAvg[1] = tSum[1] * Avg;
                iAvg[2] = tSum[2] * Avg;
                iAvg[3] = tSum[3] * Avg;

                for (int j = 0; j < Hblur.Height; j++)
                {
                    if (j - kSize / 2 >= 0 && j + 1 + kSize / 2 < Hblur.Height)
                    {
                        Color tmp_pColor = Hblur.GetPixel(i, j - kSize / 2);
                        tSum[0] -= tmp_pColor.A;
                        tSum[1] -= tmp_pColor.R;
                        tSum[2] -= tmp_pColor.G;
                        tSum[3] -= tmp_pColor.B;
                        Color tmp_nColor = Hblur.GetPixel(i, j + 1 + kSize / 2);
                        tSum[0] += tmp_nColor.A;
                        tSum[1] += tmp_nColor.R;
                        tSum[2] += tmp_nColor.G;
                        tSum[3] += tmp_nColor.B;
                        //
                        iAvg[0] = tSum[0] * Avg;
                        iAvg[1] = tSum[1] * Avg;
                        iAvg[2] = tSum[2] * Avg;
                        iAvg[3] = tSum[3] * Avg;
                    }
                    image.Bitmap.SetPixel(i, j, Color.FromArgb((int)iAvg[0], (int)iAvg[1], (int)iAvg[2], (int)iAvg[3]));
                }
            }
        }
        // Повысить резкость/размыть 
        public static uint[,] Filtration(IPicture image)
        {
            PixelPoint rgb = new PixelPoint();
            Color c;
            double[,] matrix = new double[,] {{-1, -1, -1}, // sharpness
                                                 {-1,  9, -1},
                                                 {-1, -1, -1}};
            for (int y = 1; y < image.Bitmap.Height-1; y++)
                for (int x = 1; x < image.Bitmap.Width-1; x++)
                {
                    c = image.Bitmap.GetPixel(x, y);
                    rgb.R = 0;
                    rgb.G = 0;
                    rgb.B = 0;
                    for (int k = 0; k < 3; k++)
                        for (int m = 0; m < 3; m++)
                        {
                            ColorOfCell = calculationOfColor(tmppixel[i - 1 + k, j - 1 + m], matrix[k, m]);
                            ColorOfPixel.R += ColorOfCell.R;
                            ColorOfPixel.G += ColorOfCell.G;
                            ColorOfPixel.B += ColorOfCell.B;
                        }

                    image.Bitmap.SetPixel(x, y, Color.FromArgb(c.R, c.G, rgb.R));
                }
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
            for (int i = 1; i < tmpH + 1; i++)
                for (int j = 1; j < tmpW + 1; j++)
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
