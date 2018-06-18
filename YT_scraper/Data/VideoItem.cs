using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using YoutubeExtractor;

namespace YT_scraper.Data
{
    public class VideoItem
    {
        public string title  { get;  }
        public string url { get; }
        public string imgUrl { get; }
        public string id { get; }
        public VideoItem (string titleArg ,string idArg)
        {
            string baseUrl = idArg;
            title = titleArg;
            url = "https://www.youtube.com/watch?v=" + idArg;
            Match match = Regex.Match(url, @"www\.youtube\.com\/watch\?v=(.*?)$", RegexOptions.Singleline);
            imgUrl = "https://i.ytimg.com/vi/" + idArg+ "/hqdefault.jpg";
            id = idArg;
            
        }

    }
}
