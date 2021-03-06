using System.Drawing.Imaging;

namespace BestRedactor.Data.AutoSave
{
    public class AutoSaveSettings
    {
        public int           OpenTabs     {get; set;}
        public string[]      Directory    {get; set;}
        public string[]      Name         {get; set;}
        public ImageFormat[] ImageFormats {get; set;}
    }
}