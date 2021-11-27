using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;
using BestRedactor.Interface;
using System.Drawing;
using BestRedactor.Logics;

namespace BestRedactor.Data.AutoSave
{
    public static class BackupSession
    {
        public static void Backup(IEnumerable<IPicture> collection)
        {
            var path = BestRedactor.Properties.Settings.Default["PathBackup"].ToString();
            path.PathNotNull();
            if (File.Exists(path)) //снятие атрибутов у временного файла
                File.SetAttributes(path!, 0);

            var openedTabs = (uint)Properties.Settings.Default["OpenedTabs"];
            var saveSettings = new AutoSaveSettings //создание экземпляра для сохранение параметров Picture
                               {
                                   OpenTabs     = openedTabs,
                                   Directory    = new string[openedTabs],
                                   Name         = new string[openedTabs],
                                   ImageFormats = new ImageFormat[openedTabs]
                               };

            var ctn = 0;
            foreach (var elem in collection) //сохранение картинок и занесение данных для сохранения в фаил
            {
                elem.Bitmap.Save($"~{elem.FileName}.{elem.ImageFormat.ToString().ToLower()}", elem.ImageFormat);
                File.SetAttributes($"~{elem.FileName}.{elem.ImageFormat.ToString().ToLower()}", FileAttributes.Hidden);
                saveSettings.Name[ctn]         = elem.FileName;
                saveSettings.Directory[ctn]    = elem.Directory;
                saveSettings.ImageFormats[ctn] = elem.ImageFormat;
                ctn++;
            }

            using var stream = File.Create(path!); //сохранение в фаил параметров Picture
            JsonSerializer.SerializeAsync(stream, saveSettings,
                typeof(AutoSaveSettings)); // красивая развёртка , new JsonSerializerOptions { WriteIndented = true }
            File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.ReadOnly);
        }

        public static IEnumerable<IPicture> LoadsSession()
        {
            var path = Properties.Settings.Default["PathBackup"].ToString(); //путь до файла с параметрами
            path.PathNotNull();

            var saveSettings =
                JsonSerializer.Deserialize<AutoSaveSettings>(File.ReadAllText(path!)); //десоциализация параметров
            var session = new List<Picture>();
            if (saveSettings == null)
                return session;
            for (var i = 0; i < saveSettings!.OpenTabs; i++)
                if (saveSettings.Name[i] != null && saveSettings.ImageFormats != null) //создание новой сессии 
                    session.Add(new Picture(
                        new Bitmap($"~{saveSettings.Name[i]}.{saveSettings.ImageFormats[i].ToString().ToLower()}"),
                        saveSettings.Directory[i],
                        saveSettings.Name[i],
                        saveSettings.ImageFormats[i]));


            return session;
        }
    }
}