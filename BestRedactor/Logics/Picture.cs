using System.Drawing;
using System.Drawing.Imaging;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public class Picture : IPicture
    {
        public Picture(Bitmap bitmap, string directory, string fileName = "NoName", ImageFormat imageFormat = default)
        {
            Bitmap      = bitmap;
            Directory   = directory;
            FileName    = fileName;
            ImageFormat = imageFormat;
        }

        public Bitmap      Bitmap {get; set;}
        public string      Directory {get; set;}
        public string      FileName {get; set;}
        public ImageFormat ImageFormat {get; set;}
    }
}