using NUnit.Framework;
using System.Drawing;

namespace BestRedactor.Tests
{
    [TestFixture]
    public class Tests
    {
        public enum Bitmaps
        {
            black,
            white,
            one_color,
            black_white,
            rgb_horizontal,
            rgb_vertical
        };

        public static Color[,] BitmapToColor(Bitmap bm)
        {
            Color[,] colors = new Color[bm.Width, bm.Height];
            for (int x = 0; x < bm.Width; x++)
            for (int y = 0; y < bm.Height; y++)
                colors[x, y] = bm.GetPixel(x, y);
            return colors;
        }

        public static Bitmap MockInputData(Bitmaps bm)
        {
            Bitmap res = new Bitmap(6, 6);
            switch (bm)
            {
                case Bitmaps.black:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(255, 0,0,0));
                    break;
                };
                case Bitmaps.white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(100,200,60));
                    break;
                };
                case Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 3) 
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        else
                            res.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    break;
                };
                case Bitmaps.rgb_horizontal:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 2) 
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                    }
                    break;
                };
                case Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                    }
                    break;
                };
            }
            return res;
        }
    }
}