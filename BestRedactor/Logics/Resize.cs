using System.Drawing;

namespace BestRedactor.Logics
{
    public static class Resize
    {
        public static Bitmap Resizing(Bitmap image, double coefficient)
        {
            var resized = new Bitmap(image,
                new Size((int)(image.Width*coefficient),
                (int)(image.Height*coefficient)));
            return resized;
        }

    }
}