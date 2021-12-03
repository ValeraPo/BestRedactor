using System.Collections.Generic;
using System.Text.RegularExpressions;
using BestRedactor.Data;
using BestRedactor.Interface;

namespace BestRedactor.Logics
{
    public class FileManagerL
    {
        public static void Save(IPicture picture) => FileManager.Save(picture);
        public static void SaveAs(IPicture picture, string fileName)
        {
            fileName.PathNotNull();
            var regex = new Regex(@"[^\\]*\.\w*$", RegexOptions.IgnoreCase); //разделение путя файла на папку и имя с типом
            var fileNameAndType = regex.Match(fileName).ToString(); //имя и тип
            picture.Directory = regex.Replace(fileName, ""); //папка
            regex = new Regex(@"\.\S*");
            picture.FileName = regex.Replace(fileNameAndType, ""); //имя файфла

            FileManager.SaveAs(picture);
        }
        public static void SaveAll(IEnumerable<IPicture> pictures)
        {
            foreach (var elem in pictures)
                FileManager.Save(elem);
        } 

        public static IPicture Load(string path) => FileManager.Load(path);
        public static IPicture LoadFromClipboard() => FileManager.LoadFromClipboard();
    }
}