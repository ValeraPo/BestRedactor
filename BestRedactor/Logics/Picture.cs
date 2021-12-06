using System;
using System.Drawing;
using System.Drawing.Imaging;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public class Picture : IPicture
    {
        public Picture(Bitmap bitmap, string directory, string fileName, ImageFormat imageFormat)
        {
            Bitmap      = bitmap;
            Directory   = directory;
            FileName    = fileName;
            ImageFormat = imageFormat;
        }
        public Picture(Bitmap bitmap):
            this(bitmap, Environment.ExpandEnvironmentVariables(@"%userprofile%\Pictures\"),"NoName", ImageFormat.MemoryBmp){}

        public Bitmap      Bitmap      {get; set;}
        public string      Directory   {get; set;}
        public string      FileName    {get; set;}
        public ImageFormat ImageFormat {get; set;}
    }
}