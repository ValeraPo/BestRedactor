using System.Drawing;
using System.Drawing.Imaging;

namespace BestRedactor.Interface
{
    public interface IPicture
    {
        public Bitmap Bitmap {get; set;}
        public string Directory {get; set;}
        public string FileName {get; set;}
        public ImageFormat ImageFormat {get; set;}
    }
}