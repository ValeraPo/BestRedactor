using System.Drawing;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public static class Resize
    {
        // Обратите внимание что данный метод возвращает битмап, и никак не меняет исходное изображение
        public static Bitmap Resizing(Bitmap image, double coefficient)
        {
            Bitmap resized = new Bitmap(image,
                new Size((int)(image.Width*coefficient),
                (int)(image.Height*coefficient)));
            return resized;
        }

    }
}