using System.Drawing;

namespace BestRedactor.Interface
{
    public interface ISettings
    {
        public Color LastUseColor {get; set;}
        public uint LastUseSize {get; set;}
        public uint OpenedTabs {get; set;}
        public bool FailClose {get; set;}
    }
}