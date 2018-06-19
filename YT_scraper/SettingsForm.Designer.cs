namespace YT_scraper
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVlcBrowse = new System.Windows.Forms.Button();
            this.textBoxVLCPath = new System.Windows.Forms.TextBox();
            this.vlcOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCacheBrowse = new System.Windows.Forms.Button();
            this.textBoxChacheLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDownloadLocation = new System.Windows.Forms.Button();
            this.textBoxDownload = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose VLC Location";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonVlcBrowse);
            this.panel1.Controls.Add(this.textBoxVLCPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 66);
            this.panel1.TabIndex = 1;
            // 
            // buttonVlcBrowse
            // 
            this.buttonVlcBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVlcBrowse.Location = new System.Drawing.Point(482, 25);
            this.buttonVlcBrowse.Name = "buttonVlcBrowse";
            this.buttonVlcBrowse.Size = new System.Drawing.Size(101, 31);
            this.buttonVlcBrowse.TabIndex = 2;
            this.buttonVlcBrowse.Text = "Browse";
            this.buttonVlcBrowse.UseVisualStyleBackColor = true;
            this.buttonVlcBrowse.Click += new System.EventHandler(this.buttonVlcBrowse_Click);
            // 
            // textBoxVLCPath
            // 
            this.textBoxVLCPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxVLCPath.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVLCPath.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxVLCPath.Location = new System.Drawing.Point(7, 25);
            this.textBoxVLCPath.Name = "textBoxVLCPath";
            this.textBoxVLCPath.ReadOnly = true;
            this.textBoxVLCPath.Size = new System.Drawing.Size(468, 31);
            this.textBoxVLCPath.TabIndex = 1;
            this.textBoxVLCPath.Text = "Not set yet";
            // 
            // vlcOpenDialog
            // 
            this.vlcOpenDialog.ShowReadOnly = true;
            this.vlcOpenDialog.Title = "Choose VLC location (vlc.exe)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonCacheBrowse);
            this.panel2.Controls.Add(this.textBoxChacheLocation);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 67);
            this.panel2.TabIndex = 3;
            // 
            // buttonCacheBrowse
            // 
            this.buttonCacheBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCacheBrowse.Location = new System.Drawing.Point(481, 25);
            this.buttonCacheBrowse.Name = "buttonCacheBrowse";
            this.buttonCacheBrowse.Size = new System.Drawing.Size(101, 31);
            this.buttonCacheBrowse.TabIndex = 2;
            this.buttonCacheBrowse.Text = "Browse";
            this.buttonCacheBrowse.UseVisualStyleBackColor = true;
            this.buttonCacheBrowse.Click += new System.EventHandler(this.buttonCacheBrowse_Click);
            // 
            // textBoxChacheLocation
            // 
            this.textBoxChacheLocation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxChacheLocation.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChacheLocation.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxChacheLocation.Location = new System.Drawing.Point(7, 25);
            this.textBoxChacheLocation.Name = "textBoxChacheLocation";
            this.textBoxChacheLocation.ReadOnly = true;
            this.textBoxChacheLocation.Size = new System.Drawing.Size(468, 31);
            this.textBoxChacheLocation.TabIndex = 1;
            this.textBoxChacheLocation.Text = "Not set yet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose new cache location";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonDownloadLocation);
            this.panel3.Controls.Add(this.textBoxDownload);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 66);
            this.panel3.TabIndex = 3;
            // 
            // buttonDownloadLocation
            // 
            this.buttonDownloadLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadLocation.Location = new System.Drawing.Point(482, 25);
            this.buttonDownloadLocation.Name = "buttonDownloadLocation";
            this.buttonDownloadLocation.Size = new System.Drawing.Size(101, 31);
            this.buttonDownloadLocation.TabIndex = 2;
            this.buttonDownloadLocation.Text = "Browse";
            this.buttonDownloadLocation.UseVisualStyleBackColor = true;
            this.buttonDownloadLocation.Click += new System.EventHandler(this.buttonDownloadLocation_Click);
            // 
            // textBoxDownload
            // 
            this.textBoxDownload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDownload.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDownload.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDownload.Location = new System.Drawing.Point(7, 25);
            this.textBoxDownload.Name = "textBoxDownload";
            this.textBoxDownload.ReadOnly = true;
            this.textBoxDownload.Size = new System.Drawing.Size(468, 31);
            this.textBoxDownload.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose default download location";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSettings.Location = new System.Drawing.Point(349, 303);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(101, 31);
            this.buttonSaveSettings.TabIndex = 5;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(499, 303);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 31);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose a default download folder";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 346);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVlcBrowse;
        private System.Windows.Forms.TextBox textBoxVLCPath;
        private System.Windows.Forms.OpenFileDialog vlcOpenDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCacheBrowse;
        private System.Windows.Forms.TextBox textBoxChacheLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDownloadLocation;
        private System.Windows.Forms.TextBox textBoxDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}