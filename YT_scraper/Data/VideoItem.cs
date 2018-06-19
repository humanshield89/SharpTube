using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using VideoLibrary;
namespace YT_scraper.Data
{
    public class VideoItem
    {
        public string title { get; set; }
        public string url { get; }
        private readonly string imgUrl = "https://i.ytimg.com/vi/";
        public string id { get; }
        public IEnumerable<YouTubeVideo> videos { set; get; }
        public VideoItem(string titleArg, string idArg)
        {
            title = titleArg;
            url = "https://www.youtube.com/watch?v=" + idArg;
            id = idArg;
        }

        public VideoItem(string idArg)
        {
           
            url = "https://www.youtube.com/watch?v=" + idArg;
            id = idArg;
        }

        public string DownloadThumbHQImage()
        {
            string path = SSettings.getCacheFolder() + id + "_HQ.jpg";
            using (WebClient webClient = new WebClient())
            {
                Directory.CreateDirectory(SSettings.getCacheFolder());


                try
                {
                    if (!File.Exists(path))
                        webClient.DownloadFile(imgUrl + id + "/maxresdefault.jpg", path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }

            }
            return path;
        }

        public string DownloadThumbNormalImage()
        {
            string path = SSettings.getCacheFolder() + id + "_normal.jpg";
            using (WebClient webClient = new WebClient())
            {
                Directory.CreateDirectory(SSettings.getCacheFolder());


                try
                {
                    if (!File.Exists(path))
                        webClient.DownloadFile(imgUrl + id + "/hqdefault.jpg", path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }

            }
            return path;
        }

        public string DownloadThumbSmallImage()
        {
            string path = SSettings.getCacheFolder() + id + "_small.jpg";
            using (WebClient webClient = new WebClient())
            {
                Directory.CreateDirectory(SSettings.getCacheFolder());

                
                try
                {
                    if (!File.Exists(path))
                        webClient.DownloadFile(imgUrl + id + "/mqdefault.jpg", path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }

            }
            return path;
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
            try
            {
                videos = youTube.GetAllVideosAsync(url).Result;
            }
            catch (Exception)
            {
                MessageBox.Show("Check your internet connection and try again","Network Error");
            }
            if (title == null)
                title = videos.ElementAt(0).Title;
        }
    }
}
