using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;
using System.Drawing;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Data.AutoSave
{
    public static class BackupSession
    {
        public static void Backup(object obj)
        {
            var path = Settings.PathBackup;
            path.PathNotNull();
            if (File.Exists(path)) //снятие атрибутов у временного файла
            {
                File.SetAttributes(path!, 0);
                //чтение из файла старых настроек для удаления старых картинок
                var saveSettingsOld = JsonSerializer.Deserialize<AutoSaveSettings>(File.ReadAllText(path!));
                if (saveSettingsOld != null)
                    for (var i = 0; i < saveSettingsOld.OpenTabs; i++)
                    {
                        var pathTmp = $"~{saveSettingsOld.Name[i]}.{saveSettingsOld.ImageFormats[i].ToString().ToLower()}";
                        if (File.Exists(pathTmp))
                            File.Delete(pathTmp);
                    }
                        
            }

            var openedTabs = Settings.OpenedTabs;
            var saveSettings = new AutoSaveSettings //создание экземпляра для сохранение параметров Picture
                               {
                                   OpenTabs     = openedTabs,
                                   Directory    = new string[openedTabs],
                                   Name         = new string[openedTabs],
                                   ImageFormats = new ImageFormat[openedTabs]
                               };
            var cnt = 0;
            foreach (var elem in (IEnumerable<IPicture>)obj)
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
            var path = Settings.PathBackup; //путь до файла с параметрами
            path.PathNotNull();

            var saveSettings = JsonSerializer.Deserialize<AutoSaveSettings>(File.ReadAllText(path!)); //десоциализация параметров
            var session = new List<Picture>();
            if (saveSettings == null)
                return session;
            path = Environment.ExpandEnvironmentVariables(@"%appdata%\BestRedactor\");
            path.DirectoryCreature(true);
            for (var i = 0; i < saveSettings!.OpenTabs; i++)
            {
                var pathTmp = $"~{saveSettings.Name[i]}.{saveSettings.ImageFormats[i].ToString().ToLower()}";
                if (saveSettings.Name[i] == null || saveSettings.ImageFormats == null)
                    continue;
                File.Copy(pathTmp, path + pathTmp);
                session.Add(new Picture(
                    new Bitmap(
                        $"{path}~{saveSettings.Name[i]}.{saveSettings.ImageFormats[i].ToString().ToLower()}"),
                    saveSettings.Directory[i],
                    saveSettings.Name[i],
                    saveSettings.ImageFormats[i]));
            }

            return session;
        }
    }
}