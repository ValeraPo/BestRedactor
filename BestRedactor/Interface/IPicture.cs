using System.Drawing;

namespace BestRedactor.Interface
{
    public interface IPicture
    {
        public Bitmap Bitmap {get; set;}
        public string FileName {get; set;}
        public System.Drawing.Imaging.ImageFormat ImageFormat {get; set;}
    }
}