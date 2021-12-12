using System.Collections.Generic;
using System.Threading;
using BestRedactor.Interface;
using BestRedactor.Data.AutoSave;

namespace BestRedactor.Logics
{
    public static class AutoSave
    {
        // Дергать этот метод по таймеру
        public static void Backup(IEnumerable<IPicture> collection)
        {
            new Thread(BackupSession.Backup).Start(collection);
        }
        // Запускается при ошибке сохранения файлов
        public static IEnumerable<IPicture> LoadsSession()
        {
            return BackupSession.LoadsSession();            
        }
    }
}
