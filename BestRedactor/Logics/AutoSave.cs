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
        // Дергать этот метод по таймеру
        public static void Backup(IEnumerable<IPicture> collection)
        {
            BackupSession.Backup(collection);
        }
        // Запускается при ошибке сохранения файлов
        public static IEnumerable<IPicture> LoadsSession()
        {
            return BackupSession.LoadsSession();            
        }
    }
}
