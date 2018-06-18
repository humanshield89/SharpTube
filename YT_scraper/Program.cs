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
            Directory.CreateDirectory(Constants.downloadFolder);
            Directory.CreateDirectory(Path.GetTempPath() + @"\YT_Utility/");
            foreach (var str in Directory.GetFiles(Path.GetTempPath() + @"\YT_Utility/") )
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
            foreach (var str in Directory.GetFiles(Path.GetTempPath() + @"\thumbs/"))
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
