using System.Drawing;

namespace BestRedactor.Logics
{
    public static class Settings
    {
        private static void SetValue<T>(string key, T value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }
        private static T GetValue<T>(string key)
        {
            return (T)Properties.Settings.Default[key];
        }
        
        public static Color  LastUseColor
        {
            get => GetValue<Color>("LastUseColor");
            set => SetValue("LastUseColor", value);
        }
        public static Color SecondColor
        {
            get => GetValue<Color>("SecondColor");
            set => SetValue("SecondColor", value);
        }
        public static float   LastUseSize
        {
            get => GetValue<float>("LastUseSize");
            set => SetValue("LastUseSize", value);
        }
        public static int   OpenedTabs
        {
            get => GetValue<int>("OpenedTabs");
            set => SetValue("OpenedTabs", value);
        }
        public static bool   FailClose
        {
            get => GetValue<bool>("FailClose");
            set => SetValue("FailClose", value);
        }
        public static string PathBackup
        {
            get => GetValue<string>("PathBackup");
            set => SetValue("PathBackup", value);
        }
    }
}