using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT_scraper.Data;
using YT_scraper.Utility;

namespace YT_scraper
{
    public class SSettings
    {
        private static string downloadFolder;
        private static string cacheFolder;
        private static string vlcFile;
        private static string currentLocation;

        public static string getCurrentLocation ()
        {
            
            if (string.IsNullOrWhiteSpace(currentLocation))
            {
                string exe = System.Reflection.Assembly.GetExecutingAssembly().Location;//System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                string directory = System.IO.Path.GetDirectoryName(exe);
                //directory = new Uri(directory).;
                currentLocation = directory;
            }

            return currentLocation;
        }


        public static string getDownloadFolder()
        {
            if(!string.IsNullOrWhiteSpace(downloadFolder))
            return downloadFolder;
            return Constants.DefaultdownloadFolder;
        }

        public static void setDownloadFolder(string downfolder)
        {
            downloadFolder = downfolder +"/";
            File.WriteAllText(currentLocation +"/assets/configurations/d_f", downloadFolder);
        }

        public static string getCacheFolder()
        {
            if (!string.IsNullOrWhiteSpace(cacheFolder))
            {
                return cacheFolder;
            }
            return Constants.DefaultCacheFolder;
        }

        public static void SetCacheFolder(string NewcacheDir)
        {
            cacheFolder = NewcacheDir +"/";
            File.WriteAllText(currentLocation +"/assets/configurations/d_c", cacheFolder);
        }

        public static void SetVlcFile(string vlcPath)
        {
            vlcFile = vlcPath;
            File.WriteAllText(currentLocation+"/assets/configurations/d_v", vlcFile);
        }

        public static string GetVlcFile()
        {
            if (!string.IsNullOrWhiteSpace(vlcFile))
            {
                return vlcFile;
            }
            return FilesUtilities.GetVlcPath();
        }

        public static void loadSettings()
        {
            // default download folder
            string downfolder = File.ReadAllText(currentLocation +"/assets/configurations/d_f");
            if (downfolder == "default" || string.IsNullOrWhiteSpace(downfolder))
            {
                downfolder = Constants.DefaultdownloadFolder; 
            }
            else
            downloadFolder = downfolder;

            // default chache location
            cacheFolder = File.ReadAllText(currentLocation +"/assets/configurations/d_c");
            if (cacheFolder == "default" || string.IsNullOrWhiteSpace(cacheFolder))
            {
                cacheFolder = Constants.DefaultCacheFolder;
            }

            // default vlc file
            vlcFile = File.ReadAllText(currentLocation + "/assets/configurations/d_v");
            if(vlcFile == "default" || string.IsNullOrWhiteSpace(vlcFile))
            {
                vlcFile = FilesUtilities.GetVlcPath();
            }
            

                
        }


    }
}
