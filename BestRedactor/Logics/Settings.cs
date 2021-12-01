using System.Drawing;

namespace BestRedactor.Logics
{
    public static class Settings
    {
        private static void Save()
        {
            Properties.Settings.Default.Save();
        }
        
        public static Color  LastUseColor
        {
            get => (Color)Properties.Settings.Default["LastUseColor"];
            set 
            { 
                Properties.Settings.Default["LastUseColor"] = value;
                Save();
            }
        }
        public static uint   LastUseSize
        {
            get => (uint)Properties.Settings.Default["LastUseSize"];
            set 
            {
                Properties.Settings.Default["LastUseSize"] = value;
                Save();
            }
        }
        public static uint   OpenedTabs
        {
            get => (uint)Properties.Settings.Default["OpenedTabs"];
            set
            {
                Properties.Settings.Default["OpenedTabs"] = value;
                Save();
            }
        }
        public static bool   FailClose
        {
            get => (bool)Properties.Settings.Default["FailClose"];
            set
            {
                Properties.Settings.Default["FailClose"] = value;
                Save();
            }
        }
        public static string PathBackup
        {
            get => Properties.Settings.Default["PathBackup"].ToString();
            set
            {
                Properties.Settings.Default["PathBackup"] = value;
                Save();
            }
        }
    }
}