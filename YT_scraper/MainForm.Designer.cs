using System;
using System.Windows.Forms;

namespace YT_scraper
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtSearchQuery = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listResults = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LinkColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenVLC = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuIteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemContributing = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItEmemailUS = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchQuery.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchQuery.Location = new System.Drawing.Point(164, 31);
            this.txtSearchQuery.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(566, 33);
            this.txtSearchQuery.TabIndex = 0;
            this.txtSearchQuery.Text = "Enter Keyword ,Video URL ,ID or Channel it\'s magic!";
            this.txtSearchQuery.Click += new System.EventHandler(this.txtSearchQuery_Click);
            this.txtSearchQuery.TextChanged += new System.EventHandler(this.txtSearchQuery_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(741, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(261, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Go!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listResults
            // 
            this.listResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.TitleColumn,
            this.LinkColum});
            this.listResults.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResults.FullRowSelect = true;
            this.listResults.GridLines = true;
            this.listResults.Location = new System.Drawing.Point(9, 62);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(1002, 396);
            this.listResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listResults.TabIndex = 0;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.View = System.Windows.Forms.View.Details;
            this.listResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listResults_Mouse_Clicked);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thumbnails";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 50;
            // 
            // TitleColumn
            // 
            this.TitleColumn.Text = "Title";
            this.TitleColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleColumn.Width = 446;
            // 
            // LinkColum
            // 
            this.LinkColum.Text = "Link";
            this.LinkColum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LinkColum.Width = 394;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDownload,
            this.toolStripMenuItemOpenInBrowser,
            this.toolStripMenuItemOpenVLC});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 70);
            // 
            // MenuItemDownload
            // 
            this.MenuItemDownload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingToolStripMenuItem});
            this.MenuItemDownload.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemDownload.Name = "MenuItemDownload";
            this.MenuItemDownload.Size = new System.Drawing.Size(163, 22);
            this.MenuItemDownload.Text = "Download";
            // 
            // loadingToolStripMenuItem
            // 
            this.loadingToolStripMenuItem.Name = "loadingToolStripMenuItem";
            this.loadingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadingToolStripMenuItem.Text = "Loading ...";
            // 
            // toolStripMenuItemOpenInBrowser
            // 
            this.toolStripMenuItemOpenInBrowser.Name = "toolStripMenuItemOpenInBrowser";
            this.toolStripMenuItemOpenInBrowser.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItemOpenInBrowser.Text = "Open in Browser";
            this.toolStripMenuItemOpenInBrowser.Click += new System.EventHandler(this.toolStripMenuItemOpenInBrowser_Click);
            // 
            // toolStripMenuItemOpenVLC
            // 
            this.toolStripMenuItemOpenVLC.Name = "toolStripMenuItemOpenVLC";
            this.toolStripMenuItemOpenVLC.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItemOpenVLC.Text = "Open with VLC Player";
            this.toolStripMenuItemOpenVLC.Click += new System.EventHandler(this.toolStripMenuItemOpenVLC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchQuery);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 69);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 494);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.listResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1025, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search YouTube!";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "UpjKlOM7KQ4_small.jpg");
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuIteFile,
            this.ToolStripMenuItemEdition,
            this.ToolStripMenuItemAbout});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(1039, 24);
            this.menuStripMainForm.TabIndex = 6;
            this.menuStripMainForm.Text = "menuStrip2";
            // 
            // ToolStripMenuIteFile
            // 
            this.ToolStripMenuIteFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExit});
            this.ToolStripMenuIteFile.Name = "ToolStripMenuIteFile";
            this.ToolStripMenuIteFile.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuIteFile.Text = "File";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemExit.Text = "Exit";
            // 
            // ToolStripMenuItemEdition
            // 
            this.ToolStripMenuItemEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings});
            this.ToolStripMenuItemEdition.Name = "ToolStripMenuItemEdition";
            this.ToolStripMenuItemEdition.Size = new System.Drawing.Size(122, 20);
            this.ToolStripMenuItemEdition.Text = "Edition";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSettings.Text = "Settings";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLicense,
            this.ToolStripMenuItemHelp,
            this.ToolStripMenuItemContributing,
            this.ToolStripMenuItEmemailUS});
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.ToolStripMenuItemAbout.Text = "About";
            // 
            // ToolStripMenuItemLicense
            // 
            this.ToolStripMenuItemLicense.Name = "ToolStripMenuItemLicense";
            this.ToolStripMenuItemLicense.Size = new System.Drawing.Size(213, 22);
            this.ToolStripMenuItemLicense.Text = "License";
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(213, 22);
            this.ToolStripMenuItemHelp.Text = "Help";
            // 
            // ToolStripMenuItemContributing
            // 
            this.ToolStripMenuItemContributing.Name = "ToolStripMenuItemContributing";
            this.ToolStripMenuItemContributing.Size = new System.Drawing.Size(213, 22);
            this.ToolStripMenuItemContributing.Text = "Contributing & Source code";
            // 
            // ToolStripMenuItEmemailUS
            // 
            this.ToolStripMenuItEmemailUS.Name = "ToolStripMenuItEmemailUS";
            this.ToolStripMenuItEmemailUS.Size = new System.Drawing.Size(213, 22);
            this.ToolStripMenuItEmemailUS.Text = "Email US";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 537);
            this.Controls.Add(this.menuStripMainForm);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CharpTube™";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox txtSearchQuery;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listResults;
        private System.Windows.Forms.ColumnHeader TitleColumn;
        private System.Windows.Forms.ColumnHeader LinkColum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenInBrowser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenVLC;
        private ToolStripMenuItem MenuItemDownload;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ToolStripMenuItem loadingToolStripMenuItem;
        private ImageList imageList1;
        private MenuStrip menuStripMainForm;
        private ToolStripMenuItem ToolStripMenuIteFile;
        private ToolStripMenuItem ToolStripMenuItemExit;
        private ToolStripMenuItem ToolStripMenuItemEdition;
        private ToolStripMenuItem ToolStripMenuItemSettings;
        private ToolStripMenuItem ToolStripMenuItemAbout;
        private ToolStripMenuItem ToolStripMenuItemLicense;
        private ToolStripMenuItem ToolStripMenuItemHelp;
        private ToolStripMenuItem ToolStripMenuItemContributing;
        private ToolStripMenuItem ToolStripMenuItEmemailUS;
    }
}

