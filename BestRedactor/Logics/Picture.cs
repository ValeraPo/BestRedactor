using System.Drawing;
using System.Drawing.Imaging;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public class Picture : IPicture
    {
        private Bitmap      _bitmap;
        private string      _fileName;
        private string      _directory;
        private ImageFormat _imageFormat;

        public Picture(Bitmap bitmap, string directory, string fileName, ImageFormat imageFormat)
        {
            Bitmap      = bitmap;
            Directory   = directory;
            FileName    = fileName;
            ImageFormat = imageFormat;
        }

        public Bitmap      Bitmap
        {
            get => _bitmap;
            set => _bitmap = value;
        }
        public string      Directory
        {
            get => _directory;
            set => _directory = value;
        }
        public string      FileName
        {
            get => _fileName;
            set => _fileName = value;
        }
        public ImageFormat ImageFormat
        {
            get => _imageFormat;
            set => _imageFormat = value;
        }
    }
}