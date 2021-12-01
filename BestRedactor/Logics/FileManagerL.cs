using BestRedactor.Data;
using BestRedactor.Interface;
using BestRedactor.Data.AutoSave;

namespace BestRedactor.Logics
{
    public class FileManagerL
    {
        public static void Save(IPicture picture) => FileManager.Save(picture);

        public static IPicture Load(string path) => FileManager.Load(path);
        
        // На всякий случай второй способ
        //public static IPicture Load(IPicture picture) => FileManager.Load(picture.FileName);

        public static IPicture LoadFromClipboard() => FileManager.LoadFromClipboard();
    }
}