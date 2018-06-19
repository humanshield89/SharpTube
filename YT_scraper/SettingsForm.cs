using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT_scraper.Data;

namespace YT_scraper
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
            textBoxVLCPath.Text = SSettings.GetVlcFile();
            textBoxDownload.Text = SSettings.getDownloadFolder();
            textBoxChacheLocation.Text = SSettings.getCacheFolder();
        }

        private void buttonVlcBrowse_Click(object sender, EventArgs e)
        {
            vlcOpenDialog.DefaultExt = ".exe";
            vlcOpenDialog.Filter = "(vlc.exe)|vlc.exe";
            var result = vlcOpenDialog.ShowDialog();
            if( result == DialogResult.OK && !string.IsNullOrWhiteSpace(vlcOpenDialog.FileName) && File.Exists(vlcOpenDialog.FileName))
            {
                textBoxVLCPath.Text = vlcOpenDialog.FileName;
            }

        }

        private void buttonDownloadLocation_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath) && Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                textBoxDownload.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonCacheBrowse_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath) && Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                textBoxChacheLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            SSettings.setDownloadFolder(textBoxDownload.Text);
            SSettings.SetVlcFile(textBoxVLCPath.Text);
            SSettings.SetCacheFolder(textBoxChacheLocation.Text);
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
