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
        private string localFileLocation;
        private string tempDownloadFile;
        private bool downloadFinished = false;
        private bool downloadStarted = false;
        private long totalSize;
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
                catch (Exception)
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

                var youTube = YouTube.Default; 
                var video = youTube.GetVideo(videoItem.url); 

                tempDownloadFile = Path.GetTempPath() + @"\YT_Utility/" + video.FullName;
                if (File.Exists(tempDownloadFile))
                {
                    try
                    {
                        File.Delete(tempDownloadFile);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR ");
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

        public void DownloadVideo(YouTubeVideo video, string VideoURL)
        {
            // TODO if a file like this already exists warn the user of the duplicated download 
            // don't waste his 
            localFileLocation = Constants.downloadFolder + @"\" + $"[{video.Resolution}]" + video.FullName;
            bool download = true;
            if (File.Exists(localFileLocation))
            {
                const string message = "This video has been already downloaded \n Do you want to re-Download it again ? ";
                const string caption = "Redownload  ?";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    download = false;
            }

            if(download)
                try
                {
                    tempDownloadFile = Path.GetTempPath() + @"\YT_Utility/" + $"[{video.Resolution}]" + video.FullName;
                    if (File.Exists(tempDownloadFile))
                    {
                        try
                        {
                            File.Delete(tempDownloadFile);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message ,"ERROR ");
                            Dispose();
                        }

                    }
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFinished);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    webClient.DownloadFileAsync(new Uri(video.Uri), tempDownloadFile);
                    startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    labRemoteLink.Text = VideoURL;
                    labLocalFile.Text = $"[{video.Resolution}]" + video.FullName;
                    Text = "Downloading " + $"[{video.Resolution}]" + video.FullName;
                 }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message ,"Network Error");
                }
            else
            {
                webClient.Dispose();
                Dispose();
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            long sizeDiferenc = e.BytesReceived - lastProgress;
            labFileSizeValue.Text = String.Format("{0:0.00}", (double)(e.TotalBytesToReceive / 1024) / 1024) + " MB";
            labDownloadSize.Text = String.Format("{0:0.00}", (double)(e.BytesReceived / 1024) / 1024) + " MB";
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long timeDiference = now - lastTime;
            labDownSpeed.Text = ((e.BytesReceived) / (now - startTime)) + " Kb/s";
            if (e.ProgressPercentage > 0)
            {
                long time = 1 ;
                try
                {
                    time = (e.TotalBytesToReceive - e.BytesReceived) / ((e.BytesReceived) / (now - startTime));
                }
                catch (DivideByZeroException)
                {

                }
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
                if (lastProgress > 0)
                {
                    Visible = true;
                    downloadStarted = true;
                }

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
            if (File.Exists(tempDownloadFile))
            if (new FileInfo(tempDownloadFile).Length == totalSize)
            {
                TopMost = true;
                Activate();
                if (!File.Exists(localFileLocation))
                {
                    File.Move(tempDownloadFile, localFileLocation);
                }
                else
                {
                    File.Delete(localFileLocation);
                    File.Copy(tempDownloadFile, localFileLocation);
                }
            }

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (!downloadFinished)
            {
                webClient.CancelAsync();
                webClient.Dispose();
                try
                {
                    File.Delete(tempDownloadFile);
                }
                catch (Exception)
                {

                }
            }

        }
        protected void Downloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!downloadFinished)
            {
                CloseCancel(e);

            }

        }

        public static void CloseCancel(FormClosingEventArgs e)
        {
            const string message = "Closing this window will cancel the download ,Your progress so far will be lost and you will have to redownload the file from the start. \n\n Are you sure you want to close this window? ";
            const string caption = "Cancel Download ?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            e.Cancel = (result == DialogResult.No);
        }

        private void getHours(long time, out int hours, out long remaining)
        {
            hours = (int)((time / 1000) / 3600);
            remaining = time - (hours * 3600 * 1000);
        }
        private void getMinutes(long time, out int minutes, out long remaining)
        {
            minutes = (int)((time / 1000) / 60);
            remaining = time - (minutes * 60 * 1000);
        }

    }
}
