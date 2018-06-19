using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_scraper.Data;

namespace YT_scraper.Utility
{
    class FilesUtilities
    {
        private static string VlcPath;
        public static bool ExploreFile(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                return false;
            }
            //Clean up file path so it can be navigated OK
            filePath = System.IO.Path.GetFullPath(filePath);
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
            return true;
        }

        public static string GetVlcPath ()
        {
            string vlc = "VLC/";
            string vlan = "VideoLAN/";
            string exe = "vlc.exe";
                                // under x86?
            string[] paths = { Constants.programFileX86Path + vlan + vlc + exe , Constants.programFileX86Path + vlc + exe,
            // under x64 aka program files ? 
            Constants.programFileX64Path + vlan + vlc + exe , Constants.programFileX64Path + vlc + exe ,
            "c:/" + vlc + exe , "c:/"+vlan + vlc +exe
            };
            if (VlcPath == null || File.Exists(VlcPath) )
            {
                foreach (var p in paths )
                {
                    if (File.Exists(p))
                    {
                        VlcPath = p;
                        return VlcPath;
                    }
                }
            }
            return VlcPath;
        }
    }
}
