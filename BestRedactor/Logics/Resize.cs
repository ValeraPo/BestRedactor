using System.Drawing;
using System;

namespace BestRedactor.Logics
{
    public static class Resize
    {
        public static Bitmap Resizing(Bitmap image, double coefficient)
        {
            if (image == null) throw new ArgumentNullException();
            if (image.Width >= 7680 || image.Height >= 7680)
                throw new ArgumentOutOfRangeException();
            var resized = new Bitmap(image, new Size((int)(image.Width*coefficient), (int)(image.Height*coefficient)));
            return resized;
        }
        // Кадрирование
        public static Bitmap Cropping(Bitmap image, Rectangle cropArea) => image.Clone(cropArea, image.PixelFormat);
    }
}