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
            this.labRemote = new System.Windows.Forms.Label();
            this.labRemoteLink = new System.Windows.Forms.LinkLabel();
            this.labLocal = new System.Windows.Forms.Label();
            this.labLocalFile = new System.Windows.Forms.Label();
            this.labFileSize = new System.Windows.Forms.Label();
            this.labFileSizeValue = new System.Windows.Forms.Label();
            this.labDownloadSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDownSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labTimeRemaining = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labRemote
            // 
            this.labRemote.AutoSize = true;
            this.labRemote.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRemote.Location = new System.Drawing.Point(12, 9);
            this.labRemote.Name = "labRemote";
            this.labRemote.Size = new System.Drawing.Size(64, 16);
            this.labRemote.TabIndex = 0;
            this.labRemote.Text = "Remote : ";
            // 
            // labRemoteLink
            // 
            this.labRemoteLink.AutoSize = true;
            this.labRemoteLink.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRemoteLink.Location = new System.Drawing.Point(128, 10);
            this.labRemoteLink.Name = "labRemoteLink";
            this.labRemoteLink.Size = new System.Drawing.Size(35, 15);
            this.labRemoteLink.TabIndex = 1;
            this.labRemoteLink.TabStop = true;
            this.labRemoteLink.Text = "None";
            // 
            // labLocal
            // 
            this.labLocal.AutoSize = true;
            this.labLocal.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLocal.Location = new System.Drawing.Point(13, 25);
            this.labLocal.Name = "labLocal";
            this.labLocal.Size = new System.Drawing.Size(52, 16);
            this.labLocal.TabIndex = 2;
            this.labLocal.Text = "Local : ";
            // 
            // labLocalFile
            // 
            this.labLocalFile.AutoSize = true;
            this.labLocalFile.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLocalFile.Location = new System.Drawing.Point(128, 25);
            this.labLocalFile.Name = "labLocalFile";
            this.labLocalFile.Size = new System.Drawing.Size(39, 16);
            this.labLocalFile.TabIndex = 3;
            this.labLocalFile.Text = "None";
            this.labLocalFile.Click += new System.EventHandler(this.labLocalFile_Click);
            // 
            // labFileSize
            // 
            this.labFileSize.AutoSize = true;
            this.labFileSize.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFileSize.Location = new System.Drawing.Point(12, 57);
            this.labFileSize.Name = "labFileSize";
            this.labFileSize.Size = new System.Drawing.Size(71, 16);
            this.labFileSize.TabIndex = 4;
            this.labFileSize.Text = "File Size : ";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Downloaded : ";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Down Speed : ";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Remaining Time : ";
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
            this.ClientSize = new System.Drawing.Size(555, 213);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labTimeRemaining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labDownSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labDownloadSize);
            this.Controls.Add(this.labFileSizeValue);
            this.Controls.Add(this.labFileSize);
            this.Controls.Add(this.labLocalFile);
            this.Controls.Add(this.labLocal);
            this.Controls.Add(this.labRemoteLink);
            this.Controls.Add(this.labRemote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VideoDownloader";
            this.Text = "Downloader";
            this.Load += new System.EventHandler(this.VideoDownloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRemote;
        private System.Windows.Forms.LinkLabel labRemoteLink;
        private System.Windows.Forms.Label labLocal;
        private System.Windows.Forms.Label labLocalFile;
        private System.Windows.Forms.Label labFileSize;
        private System.Windows.Forms.Label labFileSizeValue;
        private System.Windows.Forms.Label labDownloadSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDownSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labTimeRemaining;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFolder;
    }
}