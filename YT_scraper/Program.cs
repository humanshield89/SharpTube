using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT_scraper.Data;

namespace YT_scraper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SSettings.getCurrentLocation();
            SSettings.loadSettings();
            Directory.CreateDirectory(SSettings.getDownloadFolder());
            Directory.CreateDirectory(SSettings.getCacheFolder());
            foreach (var str in Directory.GetFiles(SSettings.getCacheFolder()))
            {
                try
                {
                    File.Delete(str);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            foreach (var str in Directory.GetFiles(SSettings.getCacheFolder()))
            {
                try
                {
                    File.Delete(str);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
