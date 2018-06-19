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
            btnSearch.Enabled = false;
            listResults.Items.Clear();
            if (txtSearchQuery.Text == "") return;
            results = YoutubeScrapeEngine.scrapeYoutube(txtSearchQuery.Text);
            if (results.Any())
            {
                int i = 0;
                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(120, 80);
                imageList.ColorDepth = ColorDepth.Depth32Bit;
                Directory.CreateDirectory(Path.GetTempPath() + "thumbs");
                foreach (VideoItem video in results)
                {
                    string path = video.DownloadThumbSmallImage();
                    imageList.Images.Add(Image.FromFile(path));

                    string[] arr = { "", "" + i, video.title, video.url };
                    ListViewItem l = new ListViewItem(arr)
                    {
                        Font = new Font("Century Gothic", 10.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        ImageIndex = i
                    };
                    listResults.Items.Add(l);


                    i++;
                }

                listResults.SmallImageList = imageList;
            }
            else
            {
                listResults.Items.Add(new ListViewItem("No Results check your enternet connection "));
            }
            btnSearch.Enabled = true;
            //long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            foreach (var video in results)
            {
                video.LoadVideos();
            }
            //MessageBox.Show("Total time = " + (DateTimeOffset.Now.ToUnixTimeMilliseconds() - start));
        }

        private void listResults_Mouse_Clicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listResults.FocusedItem.Bounds.Contains(e.Location))
                {
                    int index = listResults.FocusedItem.Index;
                    contextMenuStrip1.Show(Cursor.Position);
                    if (results[index].videos != null)
                        if (results[index].videos.Any())
                        {
                            MenuItemDownload.DropDownItems.Clear();
                            foreach (var video in results[index].videos)
                            {
                                if (video.Resolution != -1)
                                {
                                    ToolStripMenuItem t = new ToolStripMenuItem();
                                    t.Text = video.Resolution + " " + video.FileExtension;
                                    t.Click += new EventHandler(MenuItemDownloadResolution_Click);
                                    MenuItemDownload.DropDownItems.Add(t);
                                }
                            }
                        }

                }
            }
        }

        private void MenuItemDownloadResolution_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)(sender);
            string[] infos = t.Text.Split(' ');
            int res = int.Parse(infos[0]);

            int index = listResults.FocusedItem.Index;
            VideoItem video = results[index];
            openNewDownloadForm(video.getYouTubeVideoWithResAndExt(res, infos[1]), results[index].url);
        }

        private void openNewDownloadForm(YouTubeVideo item, string url)
        {
            VideoDownloader videoDownloader = new VideoDownloader();
            videoDownloader.Visible = true;
            videoDownloader.DownloadVideo(item, url);
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
