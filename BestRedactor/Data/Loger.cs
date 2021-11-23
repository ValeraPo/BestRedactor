using System;
using System.IO;

namespace BestRedactor.Data
{
    public static class Loger
    {
        private static string _path = "..\\..\\..\\Log";
        public static string Path
        {
            get => _path;
            set => _path = value;
        }
        
        public static void Log(string logMessage)
        {
            if (!Directory.Exists(_path)) 
                Directory.CreateDirectory(_path);

            using (StreamWriter w = File.AppendText($"{_path}\\log {DateTime.Now.ToShortDateString()}.txt"))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                w.WriteLine($"  :{logMessage}");
                w.WriteLine("-------------------------------");
            }
        }
    }
}