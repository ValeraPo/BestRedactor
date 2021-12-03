using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public static class Rotation
    {
        public static IPicture VerticalReflection(IPicture picture)
        {
            picture.Bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return picture;
        }
        public static IPicture HorizontalReflection(IPicture picture)
        {
            picture.Bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return picture;
        }


        public static IPicture PictureRotationBy(IPicture picture, int angle)
        {
            angle = angle > 0? angle % 360 : 360 + angle % 360;
            switch (angle)
            {
                case 90:
                    picture.Bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 180:
                    picture.Bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 270:
                    picture.Bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case 0: break;
                default:
                    picture.Bitmap = BitmapRotationBy(picture.Bitmap, angle);
                    break;
            }

            return picture;
        }

        private static Bitmap BitmapRotationBy(Bitmap bmp, int angle)
        {
            var w       = bmp.Width;
            var h       = bmp.Height;
            var pf      = PixelFormat.Format32bppArgb;
            var bkColor = Color.Transparent;

            var tempImg = new Bitmap(w, h, pf);
            var g       = Graphics.FromImage(tempImg);
            g.Clear(bkColor);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();

            var path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));
            var mtrx = new Matrix();
            // Использование System.Drawing.Drawing2D.Matrix class 
            mtrx.Rotate(angle);
            var rct    = path.GetBounds(mtrx);
            var newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
            g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.RotateTransform(angle);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
        }
    }
}