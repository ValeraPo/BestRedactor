using System;
using System.IO;

namespace BestRedactor.Data
{
    public static class Loger
    {
        public static void Log(string logMessage)
        {
            var path = Properties.Settings.Default["PathLog"].ToString();
            path.DirectoryCreature();

            using (var w = File.AppendText($"{path}\\log {DateTime.Now.ToShortDateString()}.txt"))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                w.WriteLine($"  :{logMessage}");
                w.WriteLine("-------------------------------");
            }
        }
    }
}