using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BestRedactor.Properties;

namespace BestRedactor.Data
{
    public static class Louder
    {
        public static void LoadForm()
        {
            string path = Settings.Default["PathBackup"].ToString();
            using (FileStream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bf = new();
                // Написать код создание экземпляров из файла и развернуть на их основе форму
                bf.Deserialize(stream);
            }
        }
    }
}