using System;
using System.IO;
using BestRedactor.Properties;

namespace BestRedactor.Data
{
    public static class Loger
    {
        public static void Log(string logMessage)
        {
            string path = Settings.Default["PathLog"].ToString();
            path.DirectoryCreature();

            using (StreamWriter w = File.AppendText($"{path}\\log {DateTime.Now.ToShortDateString()}.txt"))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                w.WriteLine($"  :{logMessage}");
                w.WriteLine("-------------------------------");
            }
        }
    }
}