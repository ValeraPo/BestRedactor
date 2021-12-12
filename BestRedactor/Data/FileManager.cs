using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BestRedactor.Interface;
using BestRedactor.Logics;


namespace BestRedactor.Data
{
    public static class FileManager
    {
        public static void Save(IPicture picture)
        {
            picture.FileName.PathNotNull();
            picture.Directory.PathNotNull();
            if (picture.Bitmap == null)
                throw new ArgumentNullException(nameof(picture.Bitmap), @"Для сохранения должно быть содержимое");
            if (picture.ImageFormat == null)
                throw new ArgumentNullException(nameof(picture.ImageFormat), @"Для сохранения должен быть указан тип");

            picture.Directory.DirectoryCreature();
            var path = $"{picture.Directory}{picture.FileName}.{picture.ImageFormat.ToString().ToLower()}";
            if (File.Exists(path))
                File.Delete(path);
            picture.Bitmap.Save(path, picture.ImageFormat);
        }
        public static void SaveAs(IPicture picture)
        {
            picture.FileName.PathNotNull();
            picture.Directory.PathNotNull();
            if (picture.Bitmap == null)
                throw new ArgumentNullException(nameof(picture.Bitmap), @"Для сохранения должно быть содержимое");
            if (picture.ImageFormat == null)
                throw new ArgumentNullException(nameof(picture.ImageFormat), @"Для сохранения должен быть указан тип");

            picture.Directory.DirectoryCreature();
            var path = $"{picture.Directory}{picture.FileName}.{picture.ImageFormat.ToString().ToLower()}";
            if (File.Exists(path))
                File.Delete(path);
            picture.Bitmap.Save(path, picture.ImageFormat);
        }


        public static IPicture Load(string path)
        {
            path.PathNotNull();
            var regex = new Regex(@"[^\\]*\.\w*$", RegexOptions.IgnoreCase); //разделение путя файла на папку и имя с типом
            var fileNameAndType = regex.Match(path).ToString();           //имя и тип
            var dir             = regex.Replace(path, "");                //папка
            
            regex = new Regex(@"\.");
            var fileNameType    = regex.Split(fileNameAndType);           //разделение имени и типа
            var imageFormat     = fileNameType[1].ToLower() switch        //выбор типа
            {
                "bmp"       => ImageFormat.Bmp,
                "emf"       => ImageFormat.Emf,
                "exif"      => ImageFormat.Exif,
                "gif"       => ImageFormat.Gif,
                "icon"      => ImageFormat.Icon,
                "jpeg"      => ImageFormat.Jpeg,
                "jpg"       => ImageFormat.Jpeg,
                "png"       => ImageFormat.Png,
                "tiff"      => ImageFormat.Tiff,
                "wmf"       => ImageFormat.Wmf,
                "memorybmp" => ImageFormat.MemoryBmp,
                _           => throw new AggregateException("Не поддерживаемый тип данных")
            };

            return new Picture(new Bitmap(path), dir, fileNameType[0], imageFormat);
        }
        public static IPicture LoadFromClipboard()
        {
            if (!Clipboard.ContainsImage())
                throw new InvalidDataException("В буфере обмена не содержится картинка");

            return new Picture(new Bitmap(Clipboard.GetImage()!),
                Environment.ExpandEnvironmentVariables(@"%userprofile%\Pictures\"),
                "Clipboard", ImageFormat.Png);
        }
    }
}