using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public static class Rotation
    {
        public static Bitmap VerticalReflection(Bitmap bm)
        {
            bm?.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return bm;
        }
        public static Bitmap HorizontalReflection(Bitmap bm)
        {
            bm?.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return bm;
        }


        public static Bitmap PictureRotationBy(Bitmap bm, int angle)
        {
            angle = angle > 0? angle % 360 : 360 + angle % 360;
            switch (angle)
            {
                case 90:
                    bm?.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 180:
                    bm?.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 270:
                    bm?.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case 0: break;
                default:
                    bm = RotateBitmap(bm, angle);
                    break;
            }

            return bm;
        }

        
        private static Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            // Матрицу для представления вращения
            var rotateAtOrigin = new Matrix();
            rotateAtOrigin.Rotate(angle);

            var path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, bm.Width, bm.Height));
            var rct = path.GetBounds(rotateAtOrigin);

            // Растровое изображение, чтобы удерживать повернутый результат.
            var wid    = (int)rct.Width;
            var hgt    = (int)rct.Height;
            var result = new Bitmap(wid, hgt);

            // Реальное преобразование вращения.
            var rotateAtCenter = new Matrix();
            rotateAtCenter.RotateAt(angle, new PointF(wid / 2f, hgt / 2f));

            // Изображение на новом растровом изображении.
            var gr = Graphics.FromImage(result);
            // Использование гладкой интерполяции изображений.
            gr.InterpolationMode = InterpolationMode.High;

            // Очистите цвет в верхнем левом углу изображения.
            gr.Clear(bm.GetPixel(0, 0));

            // Отчистка
            gr.Clear(Color.Transparent);

            // Преобразование для поворота.
            gr.Transform = rotateAtCenter;

            // Изображение, центрированное по растровому изображению.
            var x = (wid - bm.Width) / 2;
            var y = (hgt - bm.Height) / 2;
            gr.DrawImage(bm, x, y);

            return result;
        }
    }
}