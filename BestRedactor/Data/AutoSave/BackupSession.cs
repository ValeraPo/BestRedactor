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
            if (File.Exists(path))
                File.SetAttributes(path!, 0);

            var openedTabs = (uint)Properties.Settings.Default["OpenedTabs"];
            var saveSettings = new AutoSaveSettings
                               {
                                   Directory    = new string[openedTabs],
                                   Name         = new string[openedTabs],
                                   ImageFormats = new ImageFormat[openedTabs]
                               };

            var ctn = 0;
            foreach (var elem in collection)
            {
                elem.Bitmap.Save($"~{elem.FileName}", elem.ImageFormat);
                File.SetAttributes($"~{elem.FileName}.{elem.ImageFormat.ToString().ToLower()}", FileAttributes.Hidden);
                saveSettings.Name[ctn]         = elem.FileName;
                saveSettings.Directory[ctn]    = elem.Directory;
                saveSettings.ImageFormats[ctn] = elem.ImageFormat;
                ctn++;
            }

            using var stream = File.Create(path!);
            JsonSerializer.SerializeAsync(stream, saveSettings,
                typeof(AutoSaveSettings)); // красивая развёртка , new JsonSerializerOptions { WriteIndented = true }
            File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.ReadOnly);
        }

        public static IEnumerable<IPicture> LoadsSession()
        {
            var path = Properties.Settings.Default["PathBackup"].ToString();
            path.PathNotNull();

            var saveSettings = JsonSerializer.Deserialize<AutoSaveSettings>(File.ReadAllText(path!));
            var session      = new List<Picture>();
            for (var i = 0; i < (uint)Properties.Settings.Default["OpenedTabs"]; i++)
            {
                if (saveSettings != null)
                    session.Add(new Picture(
                        new Bitmap($"~{saveSettings.Name[i]}.{saveSettings.ImageFormats[i].ToString().ToLower()}"),
                        saveSettings.Directory[i],
                        saveSettings.Name[i],
                        saveSettings.ImageFormats[i]));
            }

            return session;
        }
    }
}