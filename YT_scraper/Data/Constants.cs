using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_scraper.Utility;

namespace YT_scraper.Data
{
    struct Constants
    {
        public static string programFileX86Path = "C:/Program Files (x86)/";
        public static string programFileX64Path = "C:/Program Files/";

        public static string downloadFolder = KnownFolders.GetPath(KnownFolder.Downloads)+ @"\Youtube Utility";
        public static string pattern = @"<a href=""/watch\?v=(.*?)"" class=""yt-uix-tile-link yt-ui-ellipsis yt-ui-ellipsis-2 yt-uix-sessionlink      spf-link "" data-sessionlink="".*?"".*?title=""(.*?)"".*?>(.*?)</a>";
    }
}
