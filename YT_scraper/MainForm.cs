using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeExtractor;
using YT_scraper.Data;
using YT_scraper.Utility;
using YT_scraper.Workers;

namespace YT_scraper
{
    public partial class MainForm : Form
    {
        List<VideoItem> results = new List<VideoItem>();
        Process process = new Process();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listResults.Items.Clear();
            if (txtSearchQuery.Text == "") return;
            results = YoutubeScrapeEngine.scrapeYoutube(txtSearchQuery.Text);
            if (results.Any())
            {
                int i = 0;
                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(120, 80);
                imageList.ColorDepth = ColorDepth.Depth32Bit;
                using (WebClient webClient = new WebClient())
                {
                    Directory.CreateDirectory(Path.GetTempPath() + "thumbs");
                    foreach (VideoItem video in results)
                    {
                        string path = Path.GetTempPath() + "thumbs/" + video.id + ".jpg";
                        try
                        {
                            if (!File.Exists(path))
                                webClient.DownloadFile(video.imgUrl, path);
                            imageList.Images.Add(Image.FromFile(path));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                }
                listResults.SmallImageList = imageList;
                foreach (VideoItem video in results)
                {
                    string[] arr = { "", ""+i, video.title, video.url };
                    ListViewItem l = new ListViewItem(arr)
                    {
                        Font = new Font("Century Gothic", 10.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        ImageIndex = i
                    };
                    listResults.Items.Add(l);


                    i++;
                }

            }
            else
            {
                listResults.Items.Add(new ListViewItem("No Results check your enternet connection "));
            }
            
        }

        private void listResults_Mouse_Clicked(object sender, MouseEventArgs e)
        {
            if ( e.Button == MouseButtons.Right)
            {
                if (listResults.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
 
                }
            }
        }

        private void DownloadStripClick(object sender, EventArgs e)
        {
            int index = listResults.FocusedItem.Index;
            VideoItem video = results[index];
            //Thread thread = new Thread((ThreadStart)delegate
            //{
                openNewDownloadForm(video);

            //});
            //thread.Start();
        }

        private void openNewDownloadForm(VideoItem item)
        {
            VideoDownloader videoDownloader = new VideoDownloader();
            videoDownloader.Visible = true;
            videoDownloader.DownloadVideo(item);
        }

 

         private void MenuItemDownload_Click(object sender, EventArgs e)
        {
            DownloadStripClick( sender,  e);
        }

        private void toolStripMenuItemOpenInBrowser_Click(object sender, EventArgs e)
        {
            Process.Start(results[listResults.FocusedItem.Index].url);
        }

        private void toolStripMenuItemOpenVLC_Click(object sender, EventArgs e)
            
        {
            try
            {
                process.Close();
                process.Dispose();
                ProcessStartInfo start = new ProcessStartInfo();
                // Enter in the command line arguments, everything you would enter after the executable name itself
                start.Arguments = results[listResults.FocusedItem.Index].url;
                // Enter the executable to run, including the complete path
                start.FileName = "c:/VLC/vlc.exe";
                start.CreateNoWindow = false;
                start.WindowStyle = ProcessWindowStyle.Maximized;
                process = Process.Start(start);
                process.WaitForExit();
            }
            catch (Exception exception)
            {
                // do nothing
                MessageBox.Show(exception.Message);
            }

            //process.Start("c:/VLC/vlc.exe", results[listResults.FocusedItem.Index].url);
        }

    }
}
