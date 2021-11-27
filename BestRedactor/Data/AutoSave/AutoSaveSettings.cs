using System.Drawing.Imaging;

namespace BestRedactor.Data.AutoSave
{
    public class AutoSaveSettings
    {
        public uint          OpenTabs;
        public string[]      Directory;
        public string[]      Name;
        public ImageFormat[] ImageFormats;
    }
}