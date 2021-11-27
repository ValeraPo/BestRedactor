using System.Drawing;
using BestRedactor.Interface;
using BestRedactor.Data;

namespace BestRedactor.Logics
{
    public class Settings : ISettings
    {
        public Color LastUseColor
        {
            get => (Color)Properties.Settings.Default["LastUseColor"];
            set => Properties.Settings.Default["LastUseColor"] = value;
        }
        public uint  LastUseSize
        {
            get => (uint)Properties.Settings.Default["LastUseSize"];
            set => Properties.Settings.Default["LastUseSize"] = value;
        }
        public uint  OpenedTabs
        {
            get => (uint)Properties.Settings.Default["OpenedTabs"];
            set => Properties.Settings.Default["OpenedTabs"] = value;
        }
        public bool  FailClose
        {
            get => (bool)Properties.Settings.Default["FailClose"];
            set => Properties.Settings.Default["FailClose"] = value;
        }
    }
}