using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_scraper.Utility;

namespace YT_scraper.Data
{
    struct Constants
    {
        public static readonly string APP_VERSION = "1.0.0";
        public static string programFileX86Path = "C:/Program Files (x86)/";
        public static string programFileX64Path = "C:/Program Files/";

        public static string DefaultdownloadFolder = KnownFolders.GetPath(KnownFolder.Downloads)+ @"\SharpTube";
        public static string DefaultCacheFolder = Path.GetTempPath() + @"\SharpTube/";
        public static string pattern = @"<a href=""/watch\?v=(.*?)"" class=""yt-uix-tile-link yt-ui-ellipsis yt-ui-ellipsis-2 yt-uix-sessionlink      spf-link "" data-sessionlink="".*?"".*?title=""(.*?)"".*?>(.*?)</a>";
    }
}
