namespace Test
{
    partial class FrmMusic
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusic));
            this.axMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.msMusic = new System.Windows.Forms.MenuStrip();
            this.tMMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.文件集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMusic = new System.Windows.Forms.ToolStrip();
            this.tsBrowse = new System.Windows.Forms.ToolStripButton();
            this.tsFolder = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPrives = new System.Windows.Forms.ToolStripButton();
            this.tsbtnWhile = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.fsSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenMusicFile = new System.Windows.Forms.OpenFileDialog();
            this.listPlay = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axMusicPlayer)).BeginInit();
            this.msMusic.SuspendLayout();
            this.tsMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // axMusicPlayer
            // 
            this.axMusicPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMusicPlayer.Enabled = true;
            this.axMusicPlayer.Location = new System.Drawing.Point(232, 31);
            this.axMusicPlayer.Name = "axMusicPlayer";
            this.axMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMusicPlayer.OcxState")));
            this.axMusicPlayer.Size = new System.Drawing.Size(500, 419);
            this.axMusicPlayer.TabIndex = 0;
            // 
            // msMusic
            // 
            this.msMusic.BackColor = System.Drawing.Color.White;
            this.msMusic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMMusic,
            this.设置ToolStripMenuItem,
            this.tsmHelp,
            this.tsmsExit});
            this.msMusic.Location = new System.Drawing.Point(0, 0);
            this.msMusic.Name = "msMusic";
            this.msMusic.Size = new System.Drawing.Size(732, 28);
            this.msMusic.TabIndex = 1;
            this.msMusic.Text = "播放音频";
            // 
            // tMMusic
            // 
            this.tMMusic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.添加ToolStripMenuItem});
            this.tMMusic.Name = "tMMusic";
            this.tMMusic.Size = new System.Drawing.Size(51, 24);
            this.tMMusic.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCreateFile,
            this.新建文件夹ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // tsmCreateFile
            // 
            this.tsmCreateFile.Name = "tsmCreateFile";
            this.tsmCreateFile.Size = new System.Drawing.Size(153, 24);
            this.tsmCreateFile.Text = "新建文件";
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenMusic});
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // tsmOpenMusic
            // 
            this.tsmOpenMusic.Name = "tsmOpenMusic";
            this.tsmOpenMusic.Size = new System.Drawing.Size(138, 24);
            this.tsmOpenMusic.Text = "打开文件";
            this.tsmOpenMusic.Click += new System.EventHandler(this.tsmOpenMusic_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddMedia,
            this.文件集ToolStripMenuItem});
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // tsmAddMedia
            // 
            this.tsmAddMedia.Name = "tsmAddMedia";
            this.tsmAddMedia.Size = new System.Drawing.Size(152, 24);
            this.tsmAddMedia.Text = "文件";
            this.tsmAddMedia.Click += new System.EventHandler(this.tsmAddMedia_Click);
            // 
            // 文件集ToolStripMenuItem
            // 
            this.文件集ToolStripMenuItem.Name = "文件集ToolStripMenuItem";
            this.文件集ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.文件集ToolStripMenuItem.Text = "文件集";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(51, 24);
            this.tsmHelp.Text = "帮助";
            this.tsmHelp.Click += new System.EventHandler(this.tsmHelp_Click);
            // 
            // tsmsExit
            // 
            this.tsmsExit.Name = "tsmsExit";
            this.tsmsExit.Size = new System.Drawing.Size(51, 24);
            this.tsmsExit.Text = "退出";
            this.tsmsExit.Click += new System.EventHandler(this.tsmsExit_Click);
            // 
            // tsMusic
            // 
            this.tsMusic.BackColor = System.Drawing.Color.White;
            this.tsMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMusic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBrowse,
            this.tsFolder,
            this.tsbtnPlay,
            this.tsbtnNext,
            this.tsbtnPrives,
            this.tsbtnWhile,
            this.tsbtnStop});
            this.tsMusic.Location = new System.Drawing.Point(0, 455);
            this.tsMusic.Name = "tsMusic";
            this.tsMusic.Size = new System.Drawing.Size(732, 27);
            this.tsMusic.TabIndex = 2;
            this.tsMusic.Text = "toolStrip1";
            // 
            // tsBrowse
            // 
            this.tsBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBrowse.Image = ((System.Drawing.Image)(resources.GetObject("tsBrowse.Image")));
            this.tsBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBrowse.Name = "tsBrowse";
            this.tsBrowse.Size = new System.Drawing.Size(103, 24);
            this.tsBrowse.Text = "添加媒体文件";
            this.tsBrowse.Click += new System.EventHandler(this.tsBrowse_Click);
            // 
            // tsFolder
            // 
            this.tsFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsFolder.Image")));
            this.tsFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFolder.Name = "tsFolder";
            this.tsFolder.Size = new System.Drawing.Size(103, 24);
            this.tsFolder.Text = "添加媒体目录";
            this.tsFolder.Click += new System.EventHandler(this.tsFolder_Click);
            // 
            // tsbtnPlay
            // 
            this.tsbtnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPlay.Image")));
            this.tsbtnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPlay.Name = "tsbtnPlay";
            this.tsbtnPlay.Size = new System.Drawing.Size(43, 24);
            this.tsbtnPlay.Text = "播放";
            this.tsbtnPlay.Click += new System.EventHandler(this.tsbtnPlay_Click);
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNext.Image")));
            this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.Size = new System.Drawing.Size(58, 24);
            this.tsbtnNext.Text = "下一曲";
            // 
            // tsbtnPrives
            // 
            this.tsbtnPrives.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPrives.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrives.Image")));
            this.tsbtnPrives.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrives.Name = "tsbtnPrives";
            this.tsbtnPrives.Size = new System.Drawing.Size(58, 24);
            this.tsbtnPrives.Text = "上一曲";
            // 
            // tsbtnWhile
            // 
            this.tsbtnWhile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnWhile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnWhile.Image")));
            this.tsbtnWhile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnWhile.Name = "tsbtnWhile";
            this.tsbtnWhile.Size = new System.Drawing.Size(73, 24);
            this.tsbtnWhile.Text = "循环播放";
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStop.Image")));
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(43, 24);
            this.tsbtnStop.Text = "停止";
            this.tsbtnStop.Click += new System.EventHandler(this.tsbtnStop_Click);
            // 
            // OpenMusicFile
            // 
            this.OpenMusicFile.FileName = "*.m4a";
            // 
            // listPlay
            // 
            this.listPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPlay.FormattingEnabled = true;
            this.listPlay.ItemHeight = 15;
            this.listPlay.Location = new System.Drawing.Point(0, 31);
            this.listPlay.Name = "listPlay";
            this.listPlay.Size = new System.Drawing.Size(226, 424);
            this.listPlay.TabIndex = 11;
            this.listPlay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPlay_MouseDoubleClick);
            // 
            // FrmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 482);
            this.Controls.Add(this.listPlay);
            this.Controls.Add(this.tsMusic);
            this.Controls.Add(this.msMusic);
            this.Controls.Add(this.axMusicPlayer);
            this.MainMenuStrip = this.msMusic;
            this.Name = "FrmMusic";
            this.Text = "播放音频";
            this.Load += new System.EventHandler(this.FrmMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMusicPlayer)).EndInit();
            this.msMusic.ResumeLayout(false);
            this.msMusic.PerformLayout();
            this.tsMusic.ResumeLayout(false);
            this.tsMusic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axMusicPlayer;
        private System.Windows.Forms.MenuStrip msMusic;
        private System.Windows.Forms.ToolStripMenuItem tMMusic;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmsExit;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCreateFile;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenMusic;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddMedia;
        private System.Windows.Forms.ToolStripMenuItem 文件集ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMusic;
        private System.Windows.Forms.ToolStripButton tsBrowse;
        private System.Windows.Forms.ToolStripButton tsFolder;
        private System.Windows.Forms.FolderBrowserDialog fsSelectFolder;

        private System.Windows.Forms.OpenFileDialog OpenMusicFile;
        private System.Windows.Forms.ListBox listPlay;
        private System.Windows.Forms.ToolStripButton tsbtnNext;
        private System.Windows.Forms.ToolStripButton tsbtnPrives;
        private System.Windows.Forms.ToolStripButton tsbtnWhile;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripButton tsbtnPlay;
    }
}

