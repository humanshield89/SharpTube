namespace YT_scraper
{
    partial class VideoDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoDownloader));
            this.labRemoteInfo = new System.Windows.Forms.Label();
            this.labRemoteLink = new System.Windows.Forms.LinkLabel();
            this.labLocalInfo = new System.Windows.Forms.Label();
            this.labLocalFile = new System.Windows.Forms.Label();
            this.labFileSizeInfo = new System.Windows.Forms.Label();
            this.labFileSizeValue = new System.Windows.Forms.Label();
            this.labDownloadSize = new System.Windows.Forms.Label();
            this.labDownloadSizeInfo = new System.Windows.Forms.Label();
            this.labDownSpeed = new System.Windows.Forms.Label();
            this.labDownSpeedInfo = new System.Windows.Forms.Label();
            this.labTimeRemaining = new System.Windows.Forms.Label();
            this.labRemainingTimeInfo = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labRemoteInfo
            // 
            this.labRemoteInfo.AutoSize = true;
            this.labRemoteInfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRemoteInfo.Location = new System.Drawing.Point(12, 9);
            this.labRemoteInfo.Name = "labRemoteInfo";
            this.labRemoteInfo.Size = new System.Drawing.Size(64, 16);
            this.labRemoteInfo.TabIndex = 0;
            this.labRemoteInfo.Text = "Remote : ";
            // 
            // labRemoteLink
            // 
            this.labRemoteLink.AutoSize = true;
            this.labRemoteLink.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRemoteLink.Location = new System.Drawing.Point(82, 9);
            this.labRemoteLink.Name = "labRemoteLink";
            this.labRemoteLink.Size = new System.Drawing.Size(35, 15);
            this.labRemoteLink.TabIndex = 1;
            this.labRemoteLink.TabStop = true;
            this.labRemoteLink.Text = "None";
            // 
            // labLocalInfo
            // 
            this.labLocalInfo.AutoSize = true;
            this.labLocalInfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLocalInfo.Location = new System.Drawing.Point(13, 25);
            this.labLocalInfo.Name = "labLocalInfo";
            this.labLocalInfo.Size = new System.Drawing.Size(52, 16);
            this.labLocalInfo.TabIndex = 2;
            this.labLocalInfo.Text = "Local : ";
            // 
            // labLocalFile
            // 
            this.labLocalFile.AutoSize = true;
            this.labLocalFile.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLocalFile.Location = new System.Drawing.Point(82, 25);
            this.labLocalFile.Name = "labLocalFile";
            this.labLocalFile.Size = new System.Drawing.Size(39, 16);
            this.labLocalFile.TabIndex = 3;
            this.labLocalFile.Text = "None";
            this.labLocalFile.Click += new System.EventHandler(this.labLocalFile_Click);
            // 
            // labFileSizeInfo
            // 
            this.labFileSizeInfo.AutoSize = true;
            this.labFileSizeInfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFileSizeInfo.Location = new System.Drawing.Point(12, 57);
            this.labFileSizeInfo.Name = "labFileSizeInfo";
            this.labFileSizeInfo.Size = new System.Drawing.Size(71, 16);
            this.labFileSizeInfo.TabIndex = 4;
            this.labFileSizeInfo.Text = "File Size : ";
            // 
            // labFileSizeValue
            // 
            this.labFileSizeValue.AutoSize = true;
            this.labFileSizeValue.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFileSizeValue.Location = new System.Drawing.Point(128, 57);
            this.labFileSizeValue.Name = "labFileSizeValue";
            this.labFileSizeValue.Size = new System.Drawing.Size(30, 16);
            this.labFileSizeValue.TabIndex = 5;
            this.labFileSizeValue.Text = "0kb";
            // 
            // labDownloadSize
            // 
            this.labDownloadSize.AutoSize = true;
            this.labDownloadSize.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDownloadSize.Location = new System.Drawing.Point(128, 73);
            this.labDownloadSize.Name = "labDownloadSize";
            this.labDownloadSize.Size = new System.Drawing.Size(28, 16);
            this.labDownloadSize.TabIndex = 6;
            this.labDownloadSize.Text = "NA";
            // 
            // labDownloadSizeInfo
            // 
            this.labDownloadSizeInfo.AutoSize = true;
            this.labDownloadSizeInfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDownloadSizeInfo.Location = new System.Drawing.Point(12, 73);
            this.labDownloadSizeInfo.Name = "labDownloadSizeInfo";
            this.labDownloadSizeInfo.Size = new System.Drawing.Size(91, 16);
            this.labDownloadSizeInfo.TabIndex = 7;
            this.labDownloadSizeInfo.Text = "Downloaded : ";
            // 
            // labDownSpeed
            // 
            this.labDownSpeed.AutoSize = true;
            this.labDownSpeed.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDownSpeed.Location = new System.Drawing.Point(128, 89);
            this.labDownSpeed.Name = "labDownSpeed";
            this.labDownSpeed.Size = new System.Drawing.Size(40, 16);
            this.labDownSpeed.TabIndex = 8;
            this.labDownSpeed.Text = "0kb/s";
            // 
            // labDownSpeedInfo
            // 
            this.labDownSpeedInfo.AutoSize = true;
            this.labDownSpeedInfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDownSpeedInfo.Location = new System.Drawing.Point(13, 89);
            this.labDownSpeedInfo.Name = "labDownSpeedInfo";
            this.labDownSpeedInfo.Size = new System.Drawing.Size(92, 16);
            this.labDownSpeedInfo.TabIndex = 9;
            this.labDownSpeedInfo.Text = "Down Speed : ";
            // 
            // labTimeRemaining
            // 
            this.labTimeRemaining.AutoSize = true;
            this.labTimeRemaining.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimeRemaining.Location = new System.Drawing.Point(128, 120);
            this.labTimeRemaining.Name = "labTimeRemaining";
            this.labTimeRemaining.Size = new System.Drawing.Size(52, 16);
            this.labTimeRemaining.TabIndex = 10;
            this.labTimeRemaining.Text = "infinity";
            // 
            // labRemainingTimeInfo
            // 
            this.labRemainingTimeInfo.AutoSize = true;
            this.labRemainingTimeInfo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRemainingTimeInfo.Location = new System.Drawing.Point(12, 120);
            this.labRemainingTimeInfo.Name = "labRemainingTimeInfo";
            this.labRemainingTimeInfo.Size = new System.Drawing.Size(120, 16);
            this.labRemainingTimeInfo.TabIndex = 11;
            this.labRemainingTimeInfo.Text = "Remaining Time : ";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(15, 148);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(528, 23);
            this.progressBarDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarDownload.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(412, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(16, 177);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(131, 32);
            this.btnOpenFile.TabIndex = 14;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Enabled = false;
            this.btnOpenFolder.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.Location = new System.Drawing.Point(213, 177);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(131, 32);
            this.btnOpenFolder.TabIndex = 15;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // VideoDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 213);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.labRemainingTimeInfo);
            this.Controls.Add(this.labTimeRemaining);
            this.Controls.Add(this.labDownSpeedInfo);
            this.Controls.Add(this.labDownSpeed);
            this.Controls.Add(this.labDownloadSizeInfo);
            this.Controls.Add(this.labDownloadSize);
            this.Controls.Add(this.labFileSizeValue);
            this.Controls.Add(this.labFileSizeInfo);
            this.Controls.Add(this.labLocalFile);
            this.Controls.Add(this.labLocalInfo);
            this.Controls.Add(this.labRemoteLink);
            this.Controls.Add(this.labRemoteInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VideoDownloader";
            this.Text = "Downloader : Resolving Video URL please wait ... ";
            this.Load += new System.EventHandler(this.VideoDownloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRemoteInfo;
        private System.Windows.Forms.LinkLabel labRemoteLink;
        private System.Windows.Forms.Label labLocalInfo;
        private System.Windows.Forms.Label labLocalFile;
        private System.Windows.Forms.Label labFileSizeInfo;
        private System.Windows.Forms.Label labFileSizeValue;
        private System.Windows.Forms.Label labDownloadSize;
        private System.Windows.Forms.Label labDownloadSizeInfo;
        private System.Windows.Forms.Label labDownSpeed;
        private System.Windows.Forms.Label labDownSpeedInfo;
        private System.Windows.Forms.Label labTimeRemaining;
        private System.Windows.Forms.Label labRemainingTimeInfo;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFolder;
    }
}