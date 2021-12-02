using System.Drawing;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public class Resize
    {
        // Обратите внимание что данный метод возвращает битмап, и никак не меняет исходное изображение
        public Bitmap Resizing(IPicture image, double coefficient)
        {
            Bitmap resized = new Bitmap(image.Bitmap,new Size((int)(image.Bitmap.Width*coefficient),
                (int)(image.Bitmap.Height*coefficient)));
            return resized;
        }
    }
}