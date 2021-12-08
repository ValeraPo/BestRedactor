using System.Drawing;
using System;
using System.Collections.Generic;


namespace BestRedactor.Logics
{
    public static class Filling
    {
        // метод для поиска старого цвета до заливки формы новым цветом
        private static void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            var cx = bm.GetPixel(x, y);
            var a = (uint)(Math.Abs(oldColor.A - cx.A));
            var r = (uint)(Math.Abs(oldColor.R - cx.R));
            var g = (uint)(Math.Abs(oldColor.G - cx.G));
            var b = (uint)(Math.Abs(oldColor.B - cx.B));
            if (a > 15 || r > 15 || g > 15 || b > 15)
                return;
            sp.Push(new Point(x, y));
            bm.SetPixel(x, y, newColor);
        }
        public static void Fill(Bitmap bm, int x, int y, Color newCol)
        {
            var oldCol = bm.GetPixel(x, y);
            var pixel  = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, newCol);
            if (oldCol.ToArgb() == newCol.ToArgb())
                return;
            while (pixel.Count > 0)
            {
                var pt = pixel.Pop();
                if (pt.X <= 0 || pt.Y <= 0 || pt.X >= bm.Width - 1 || pt.Y >= bm.Height - 1)
                    continue;
                Validate(bm, pixel, pt.X - 1, pt.Y, oldCol, newCol);
                Validate(bm, pixel, pt.X, pt.Y - 1, oldCol, newCol);
                Validate(bm, pixel, pt.X + 1, pt.Y, oldCol, newCol);
                Validate(bm, pixel, pt.X, pt.Y + 1, oldCol, newCol);
                Validate(bm, pixel, pt.X - 1, pt.Y - 1, oldCol, newCol);
                Validate(bm, pixel, pt.X + 1, pt.Y - 1, oldCol, newCol);
                Validate(bm, pixel, pt.X + 1, pt.Y + 1, oldCol, newCol);
                Validate(bm, pixel, pt.X - 1, pt.Y + 1, oldCol, newCol);
            }
        }
    }
}