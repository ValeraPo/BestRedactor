using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BestRedactor.Properties;

namespace BestRedactor.Data
{
    public static class AutoSave
    {
        public static void Backup(MainForm form)
        {
            string path = Settings.Default["PathBackup"].ToString();
            if (File.Exists(path))
                File.SetAttributes(path, 0);
            
            using (FileStream stream = File.Open(path, FileMode.Create))
            {
                BinaryFormatter bf = new();
                bf.Serialize(stream, form);
                File.SetAttributes(stream.Name, FileAttributes.Hidden | FileAttributes.ReadOnly);
            }
        }
    }
}