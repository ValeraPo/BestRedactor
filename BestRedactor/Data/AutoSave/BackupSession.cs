using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            {
                File.SetAttributes(path!, 0);
                //чтение из файла старых настроек для удаления старых картинок
                var saveSettingsOld = JsonSerializer.Deserialize<AutoSaveSettings>(File.ReadAllText(path!));
                if (saveSettingsOld != null)
                    for (var i = 0; i < saveSettingsOld.OpenTabs; i++)
                        File.Delete($"~{saveSettingsOld.Name[i]}.{saveSettingsOld.ImageFormats[i].ToString().ToLower()}");
            }

            var openedTabs = (uint)Properties.Settings.Default["OpenedTabs"];
            var saveSettings = new AutoSaveSettings //создание экземпляра для сохранение параметров Picture
                               {
                                   OpenTabs     = openedTabs,
                                   Directory    = new string[openedTabs],
                                   Name         = new string[openedTabs],
                                   ImageFormats = new ImageFormat[openedTabs]
                               };
            var cnt = 0;
            foreach (var elem in collection)
            {
                var pathTmp = $"~{elem.FileName}.{elem.ImageFormat.ToString().ToLower()}"; //путь до временного файла
                
                var j   = 1;
                var tmp = elem.FileName;
                while (File.Exists(pathTmp)) //проверка существует ли файл с таким имение
                {
                    tmp     = $"{elem.FileName}({j})";
                    pathTmp = $"~{tmp}.{elem.ImageFormat.ToString().ToLower()}";
                    j++;
                }

                if (j != 1) elem.FileName = tmp; //если файл существовал то переписываем имя текущего на свободное (с индексом)
                
                elem.Bitmap.Save(pathTmp, elem.ImageFormat); //сохранение изображения
                File.SetAttributes(pathTmp, FileAttributes.Hidden); //установка атрибута скрытый
                //заполнение информации о файлах в переменную для сохранения
                saveSettings.Name[cnt]         = elem.FileName;
                saveSettings.Directory[cnt]    = elem.Directory;
                saveSettings.ImageFormats[cnt] = elem.ImageFormat;
                cnt++; 
            }

            //сохранение в фаил параметров Picture
            File.WriteAllText(path!, JsonSerializer.Serialize(saveSettings)); // красивая развёртка , new JsonSerializerOptions { WriteIndented = true }
            File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.ReadOnly);
        }

        public static IEnumerable<IPicture> LoadsSession()
        {
            var path = Properties.Settings.Default["PathBackup"].ToString(); //путь до файла с параметрами
            path.PathNotNull();

            var saveSettings = JsonSerializer.Deserialize<AutoSaveSettings>(File.ReadAllText(path!)); //десоциализация параметров
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