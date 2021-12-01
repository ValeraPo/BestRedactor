using System.Text.RegularExpressions;
using BestRedactor.Data;
using BestRedactor.Interface;
using BestRedactor.Data.AutoSave;

namespace BestRedactor.Logics
{
    public class FileManagerL
    {
        public static void Save(IPicture picture) => FileManager.Save(picture);
        public static void SaveAs(IPicture picture, string fileName)
        {
            fileName.PathNotNull();
            var regex = new Regex(@"\w*\.\w*$", RegexOptions.IgnoreCase); //разделение путя файла на папку и имя с типом
            var fileNameAndType = regex.Match(fileName).ToString(); //имя и тип
            picture.Directory = regex.Replace(fileName, ""); //папка
            regex = new Regex(@"\.\w*");
            picture.FileName = regex.Replace(fileNameAndType, ""); //имя файфла

            FileManager.SaveAs(picture);
        }
        

        public static IPicture Load(string path) => FileManager.Load(path);
        public static IPicture LoadFromClipboard() => FileManager.LoadFromClipboard();
    }
}