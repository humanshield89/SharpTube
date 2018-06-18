using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using YT_scraper.Data;
using YT_scraper.Utility;

namespace YT_scraper
{
    public partial class VideoDownloader : Form
    {
        private long startTime;
        private long lastProgress;
        private long lastTime;
        private string localFileLocation ;
        private string tempDownloadFile;
        private bool downloadFinished = false;
        private bool downloadStarted = false;
        private long totalSize ;
        WebClient webClient = new WebClient();
        public VideoDownloader()
        {
            Visible = false;
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Downloader_FormClosing);
        }



        private void VideoDownloader_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!downloadFinished)
            {
                webClient.CancelAsync();
                webClient.Dispose();
                try
                {
                    File.Delete(tempDownloadFile);
                }
                catch (Exception ex)
                {

                }
            }
            Dispose();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FilesUtilities.ExploreFile(localFileLocation);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(localFileLocation);
            }
            catch (Exception ex)
            {
                //TODO :
                MessageBox.Show(ex.Message);
            }
        }

        private void labLocalFile_Click(object sender, EventArgs e)
        {
            FilesUtilities.ExploreFile(localFileLocation);
        }

        public void DownloadVideo(VideoItem videoItem)
        {
           try
            {

                // saveFileDialog1.DefaultExt = videoInfo.VideoExtension;
                // saveFileDialog1.ShowDialog(); ;
                // Console.WriteLine(saveFileDialog1.FileName);
                var youTube = YouTube.Default; // starting point for YouTube actions
                var video = youTube.GetVideo(videoItem.url); // gets a Video object with info about the video
                                                                  //MessageBox.Show(downloadFolder+ @"\" + video.FullName);
                
                //File.WriteAllBytes(downloadFolder +@"\"+ video.FullName, video.GetBytes());
                    tempDownloadFile = Path.GetTempPath() + @"\YT_Utility/" + video.FullName;
                if (File.Exists(tempDownloadFile))
                {
                    try
                    {
                        File.Delete(tempDownloadFile);
                    }
                    catch(Exception ex )
                    {
                        MessageBox.Show("ERROR ",ex.Message);
                        Dispose();
                    }

                }
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFinished);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    webClient.DownloadFileAsync(new Uri(video.Uri), tempDownloadFile);
                    startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    localFileLocation = Constants.downloadFolder + @"\" + video.FullName;
                    labRemoteLink.Text = videoItem.url;
                    labLocalFile.Text = video.FullName;
                    this.Text = "Downloading " + video.FullName;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            long sizeDiferenc = e.BytesReceived -lastProgress;
            labFileSizeValue.Text = String.Format("{0:0.00}", (double)(e.TotalBytesToReceive / 1024) / 1024) +" MB";
            labDownloadSize.Text = String.Format("{0:0.00}", (double)(e.BytesReceived / 1024) / 1024) + " MB";
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long timeDiference = now - lastTime;
            labDownSpeed.Text = ((e.BytesReceived) / (now - startTime)) + " Kb/s" ;
            // x time ====> 100% 
            // now ========> e.percentage
            // remaining time = now * 100 / now-start
            if(e.ProgressPercentage > 0)
            {
                long time = (e.TotalBytesToReceive - e.BytesReceived)/ ((e.BytesReceived) / (now - startTime));
                int hours;
                int minutes;
                int seconds;
                long remaining;
                getHours(time, out hours, out remaining);
                getMinutes(remaining, out minutes, out remaining);
                seconds = (int)remaining / 1000;
                labTimeRemaining.Text = (hours == 0 ? "" : hours + " hours ") + (minutes == 0 ? "" : minutes + " min ") + (seconds + " sec"); ;
            }
            else if (e.ProgressPercentage == 0)
            {
                labTimeRemaining.Text = "Infinity";
            }

            progressBarDownload.Value = e.ProgressPercentage;
            lastTime = now;
            lastProgress = e.TotalBytesToReceive;
            totalSize = e.TotalBytesToReceive;
            if (!downloadStarted)
            {
                Visible = true;
                downloadStarted = true;
            }

        }

        private void DownloadFinished(object sender, EventArgs e)
        {
            btnCancel.Text = "Close";
            btnOpenFolder.Enabled = true;
            btnOpenFile.Enabled = true;
            labDownSpeed.Text = "Finished!";
            labTimeRemaining.Text = "Finished!";
            downloadFinished = true;
            if(new FileInfo(tempDownloadFile).Length == totalSize)
                File.Move(tempDownloadFile, localFileLocation);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if(!downloadFinished)
            {
                webClient.CancelAsync();
                webClient.Dispose();
                try
                {
                    File.Delete(tempDownloadFile);
                }
                catch (Exception ex)
                { 

                }
            }
            
        }
        protected void Downloader_FormClosing(object sender , FormClosingEventArgs e)
        {
            if (!downloadFinished)
            {
                CloseCancel(e);
                
            }
            
        }

        public static void CloseCancel(FormClosingEventArgs e)
        {
            const string message = "Closing this window will cancel the download /n are you sure you want to close this window? ";
            const string caption = "Cancel Download ?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            e.Cancel = (result == DialogResult.No);
        }
        
        private void  getHours (long time ,out int hours ,out long remaining)
        {
            hours = (int)((time / 1000) / 3600);
            remaining = time - (hours * 3600 * 1000);
        }
        private void getMinutes (long time, out int minutes , out long remaining )
        {
            minutes = (int)((time / 1000) / 60);
            remaining = time - (minutes * 60 * 1000);
        }
 
    }
}
