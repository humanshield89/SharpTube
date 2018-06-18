using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using VideoLibrary;
using YoutubeExtractor;

namespace YT_scraper.Data
{
    public class VideoItem
    {
        public string title { get; set; }
        public string url { get; }
        public string imgUrl { get; }
        public string id { get; }
        public IEnumerable<YouTubeVideo> videos { set; get; }
        public VideoItem(string titleArg, string idArg)
        {
            string baseUrl = idArg;
            title = titleArg;
            url = "https://www.youtube.com/watch?v=" + idArg;
            //Match match = Regex.Match(url, @"www\.youtube\.com\/watch\?v=(.*?)$", RegexOptions.Singleline);
            imgUrl = "https://i.ytimg.com/vi/" + idArg + "/hqdefault.jpg";
            id = idArg;
            //getVideosAsync();
            //new Thread(() => getVideos()).Start();
        }

        public VideoItem(string idArg)
        {
            string baseUrl = idArg;

            url = "https://www.youtube.com/watch?v=" + idArg;
            //Match match = Regex.Match(url, @"www\.youtube\.com\/watch\?v=(.*?)$", RegexOptions.Singleline);
            imgUrl = "https://i.ytimg.com/vi/" + idArg + "/hqdefault.jpg";
            id = idArg;
            //            var youTube = YouTube.Default;
            //            videos = youTube.GetAllVideosAsync(url).Result;
            //            title = videos.ElementAt(0).Title;
            //getVideosAsync();
            new Thread(() => DownloadThumbLoadImage()).Start();
        }

        private void DownloadThumbLoadImage()
        {
            using (WebClient webClient = new WebClient())
            {
                Directory.CreateDirectory(Path.GetTempPath() + "thumbs");

                string path = Path.GetTempPath() + "thumbs/" + id + ".jpg";
                try
                {
                    if (!File.Exists(path))
                        webClient.DownloadFile(imgUrl, path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }

            }
        }

        public void LoadVideos()
        {
            new Thread(() => getVideos()).Start();
        }

        public YouTubeVideo getYouTubeVideoWithResAndExt(int resolution, string ext)
        {
            foreach (var video in videos)
            {
                if (video.Resolution == resolution && video.FileExtension == ext) return video;
            }
            return null;
        }

        private void getVideos()
        {
            var youTube = YouTube.Default;
            videos = youTube.GetAllVideosAsync(url).Result;
            if (title == null)
                title = videos.ElementAt(0).Title;
        }
    }
}
