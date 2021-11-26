using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public class Picture : IPicture
    {
        Bitmap _bitmap;
        string _fileName;
        ImageFormat _imageFormat;

        public Picture(Bitmap bitmap, string fileName, ImageFormat imageFormat)
        {
            bitmap = Bitmap;
            fileName = FileName;
            imageFormat = ImageFormat;
        }

        public Bitmap Bitmap 
        { 
            get => _bitmap; 
            set => _bitmap = value;
        }
        public string FileName 
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
