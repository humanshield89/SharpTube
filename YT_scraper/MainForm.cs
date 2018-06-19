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
        Form RichMessageBox = new Form();
        List<VideoItem> results = new List<VideoItem>();
        Process process = new Process();
        public MainForm()
        {
            InitializeComponent();
            // check VLC 
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

                Directory.CreateDirectory(SSettings.getCacheFolder());
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
            string vlcPath = FilesUtilities.GetVlcPath();
            if (vlcPath != null)
            {
                try
                {
                    process.Close();
                    process.Dispose();
                    ProcessStartInfo start = new ProcessStartInfo();
                    // Enter in the command line arguments, everything you would enter after the executable name itself
                    start.Arguments = results[listResults.FocusedItem.Index].url;
                    // Enter the executable to run, including the complete path
                    start.FileName = vlcPath;
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
            }
            else
            {
                MessageBox.Show("Couldn't find VLC player \n Please make sure VLC is installed on your system ","File not found vlc.exe");
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

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure You wanna quit CharpTube?";
            const string caption = "Exit ?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
               
            
        }

        private void ToolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is still under construction we apologize for this deception :/","Comming soon");
            new Settings().ShowDialog();
        }

        private void ToolStripMenuItemLicense_Click(object sender, EventArgs e)
        {

            //string message = File.ReadAllText("lisence.rtf");
            ShowRichMessageBox(" LICENSE", "./assets/lisence.rtf");
        }

        private void ShowRichMessageBox(string title, string file)
        {
            RichTextBox rtbMessage = new RichTextBox();
            rtbMessage.LoadFile(file);
            //rtbMessage.Text = message;
            rtbMessage.Dock = DockStyle.Fill;
            rtbMessage.ReadOnly = true;
            rtbMessage.BorderStyle = BorderStyle.None;
            rtbMessage.BackColor = Color.White;

            Button btn = new Button();
            btn.Text = "OK";
            btn.Dock = DockStyle.Bottom;
            btn.Font = new Font("Century Gothic", 16.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.Click += new EventHandler(LicenseOkButton_Click);
            btn.Size = new Size(500, 40);

            RichMessageBox = new Form();
            RichMessageBox.Text = title;
            RichMessageBox.StartPosition = FormStartPosition.CenterScreen;
            RichMessageBox.Size = new Size(500, 600);
            
            RichMessageBox.Controls.Add(rtbMessage);
            RichMessageBox.Controls.Add(btn);
            RichMessageBox.ShowDialog();
        }

        private void LicenseOkButton_Click(object sender ,EventArgs e)
        {
            RichMessageBox.Dispose();
        }

        private void ToolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"CharpTube™ {Constants.APP_VERSION} \n simple adfree youtube search/download ", $"CharpTube™ {Constants.APP_VERSION}");
        }

        private void ToolStripMenuItemContributing_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/humanshield89/Youtube_Utility");
        }

        private void ToolStripMenuItEmemailUS_Click(object sender, EventArgs e)
        {
            var url = "mailto:rachidboudjelida@gmail.com?subject=CharpTube&body=Dear%20Humanshield";
            Process.Start(url);
        }
    }
}
