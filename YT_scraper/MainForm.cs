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
            string searchQuery = txtSearchQuery.Text;
            if (txtSearchQuery.Text.StartsWith("https://www.youtube.com/watch?v=") ||
                txtSearchQuery.Text.StartsWith("http://www.youtube.com/watch?v=") || txtSearchQuery.Text.StartsWith("www.youtube.com/watch?v="))
            {
                searchQuery = txtSearchQuery.Text.Split('=')[1].Split('&')[0];
            }
            try
            {
                results = YoutubeScrapeEngine.scrapeYoutube(searchQuery);
            }
            catch (Exception ex)
            {
                results = new List<VideoItem>();
                MessageBox.Show(ex.Message + "\n Hint : Check your internet connection before trying again ", "Network Error");
            }
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(120, 80);
            imageList.ColorDepth = ColorDepth.Depth24Bit;
            if (results.Any())
            {
                int i = 0;

                Directory.CreateDirectory(Path.GetTempPath() + "thumbs");
                foreach (VideoItem video in results)
                {
                    string path = video.DownloadThumbSmallImage();
                    imageList.Images.Add(Image.FromFile(path));

                    string[] arr = { "", "" + (i + 1), video.title, video.url };
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
                imageList.Images.Add(imageList1.Images[0]);
                string[] arr = { "", " ", "No Results check your enternet connection ", "N/A" };
                ListViewItem t = new ListViewItem(arr)
                {
                    Font = Font = new Font("Century Gothic", 10.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ImageIndex = 0
                };

                listResults.Items.Add(t);
                listResults.SmallImageList = imageList;

            }
            btnSearch.Enabled = true;
            foreach (var video in results)
            {
                video.LoadVideos();
            }
        }

        private void listResults_Mouse_Clicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listResults.FocusedItem.Bounds.Contains(e.Location))
                {
                    int index = listResults.FocusedItem.Index;

                    if (results.Any())
                    {
                        contextMenuStrip1.Show(Cursor.Position);
                        if (results[index].videos != null)
                            if (results[index].videos.Any())
                            {
                                MenuItemDownload.DropDownItems.Clear();
                                foreach (var video in results[index].videos)
                                {
                                    if (video.Resolution != -11)
                                    {
                                        ToolStripMenuItem t = new ToolStripMenuItem();
                                        t.Text = video.Resolution + " " + video.FileExtension +" | " +
                                            (video.Resolution == -1 ? "Audio Only!" : "")
                                            +(video.AudioBitrate == -1 ? "Video Only" : "");
                                        t.Click += new EventHandler(MenuItemDownloadResolution_Click);
                                        if (video.Resolution != -1 && video.AudioBitrate != -1)
                                        {
                                            t.ForeColor = Color.LimeGreen;
                                            t.Text += "Video Format: " + video.Format + " | ";
                                            t.Text += "Audio Format: " + video.AudioFormat;
                                            t.ForeColor = Color.LimeGreen;
                                        }
                                        MenuItemDownload.DropDownItems.Add(t);
                                    }
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

        private void txtSearchQuery_Click(object sender, EventArgs e)
        {
            if (txtSearchQuery.Text == "Enter Keyword ,Video URL ,ID or Channel it's magic!")
                txtSearchQuery.Text = String.Empty;
        }

        private void txtSearchQuery_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchQuery.Text == "Enter Keyword ,Video URL ,ID or Channel it's magic!" || txtSearchQuery.Text == string.Empty ||
                txtSearchQuery.Text == " ")
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }


    }
}
