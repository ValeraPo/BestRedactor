using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BestRedactor.Data;
using BestRedactor.Forms;
using BestRedactor.Logics;

namespace BestRedactor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
         
        [STAThread]
        static void Main()
        {
            var pictures = new List<Picture>();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try { Application.Run(new MainForm(pictures)); }
            catch (Exception e)
            {
                Loger.Log(e.ToString());
                AutoSave.Backup(pictures);
            }
        }
    }
}
