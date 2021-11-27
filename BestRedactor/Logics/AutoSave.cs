using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestRedactor.Interface;
using BestRedactor.Data.AutoSave;



namespace BestRedactor.Logics
{
    public class AutoSave
    {
        static List<Picture> collection = new List<Picture>(0); // Добавлять в этот лист Picture при открытии новой вкладки

        // Дергать этот метод по таймеру
        public static void Backup()
        {
            BackupSession.Backup(collection);
        }
        // Запускается при ошибке сохранения файлов
        public static IEnumerable<IPicture> LoadsSession()
        {
            collection = (List<Picture>)BackupSession.LoadsSession();
            return collection;
        }
    }
}
