namespace MyKTV.ManageForms
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.msKTV = new System.Windows.Forms.MenuStrip();
            this.tsmManageSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeachSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSearchSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetSource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetPsource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetSsource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mstsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msKTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // msKTV
            // 
            this.msKTV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManageSinger,
            this.tsmManageSong,
            this.tsmSetSource,
            this.tsmHelp});
            this.msKTV.Location = new System.Drawing.Point(0, 0);
            this.msKTV.Name = "msKTV";
            this.msKTV.Size = new System.Drawing.Size(915, 28);
            this.msKTV.TabIndex = 0;
            this.msKTV.Text = "menuStrip1";
            // 
            // tsmManageSinger
            // 
            this.tsmManageSinger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddSinger,
            this.tsmSeachSinger,
            this.tsmExit});
            this.tsmManageSinger.Name = "tsmManageSinger";
            this.tsmManageSinger.Size = new System.Drawing.Size(106, 24);
            this.tsmManageSinger.Text = "歌手管理(&M)";
            // 
            // tsmAddSinger
            // 
            this.tsmAddSinger.Name = "tsmAddSinger";
            this.tsmAddSinger.Size = new System.Drawing.Size(138, 24);
            this.tsmAddSinger.Text = "新增歌手";
            this.tsmAddSinger.Click += new System.EventHandler(this.tsmAddSinger_Click);
            // 
            // tsmSeachSinger
            // 
            this.tsmSeachSinger.Name = "tsmSeachSinger";
            this.tsmSeachSinger.Size = new System.Drawing.Size(138, 24);
            this.tsmSeachSinger.Text = "搜索歌手";
            this.tsmSeachSinger.Click += new System.EventHandler(this.tsmSeachSinger_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(138, 24);
            this.tsmExit.Text = "退出(&E)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmManageSong
            // 
            this.tsmManageSong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSearchSong,
            this.tsmEditSong});
            this.tsmManageSong.Name = "tsmManageSong";
            this.tsmManageSong.Size = new System.Drawing.Size(106, 24);
            this.tsmManageSong.Text = "歌曲管理(&M)";
            // 
            // tsmSearchSong
            // 
            this.tsmSearchSong.Name = "tsmSearchSong";
            this.tsmSearchSong.Size = new System.Drawing.Size(138, 24);
            this.tsmSearchSong.Text = "歌曲搜索";
            this.tsmSearchSong.Click += new System.EventHandler(this.tsmSearchSong_Click);
            // 
            // tsmEditSong
            // 
            this.tsmEditSong.Name = "tsmEditSong";
            this.tsmEditSong.Size = new System.Drawing.Size(138, 24);
            this.tsmEditSong.Text = "新增歌曲";
            this.tsmEditSong.Click += new System.EventHandler(this.tsmEditSong_Click);
            // 
            // tsmSetSource
            // 
            this.tsmSetSource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSetPsource,
            this.tsmSetSsource});
            this.tsmSetSource.Name = "tsmSetSource";
            this.tsmSetSource.Size = new System.Drawing.Size(130, 24);
            this.tsmSetSource.Text = "设置资源路径(&S)";
            // 
            // tsmSetPsource
            // 
            this.tsmSetPsource.Name = "tsmSetPsource";
            this.tsmSetPsource.Size = new System.Drawing.Size(168, 24);
            this.tsmSetPsource.Text = "设置图片路径";
            this.tsmSetPsource.Click += new System.EventHandler(this.tsmSetPsource_Click);
            // 
            // tsmSetSsource
            // 
            this.tsmSetSsource.Name = "tsmSetSsource";
            this.tsmSetSsource.Size = new System.Drawing.Size(168, 24);
            this.tsmSetSsource.Text = "设置歌曲路径";
            this.tsmSetSsource.Click += new System.EventHandler(this.tsmSetSsource_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstsmHelp});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(73, 24);
            this.tsmHelp.Text = "帮助(&H)";
            // 
            // mstsmHelp
            // 
            this.mstsmHelp.Name = "mstsmHelp";
            this.mstsmHelp.Size = new System.Drawing.Size(130, 24);
            this.mstsmHelp.Text = "帮助(&H)";
            this.mstsmHelp.Click += new System.EventHandler(this.mstsmHelp_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 544);
            this.Controls.Add(this.msKTV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msKTV;
            this.Name = "FrmAdmin";
            this.Text = "KTV后台管理";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.msKTV.ResumeLayout(false);
            this.msKTV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msKTV;
        private System.Windows.Forms.ToolStripMenuItem tsmManageSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmAddSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmSeachSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmManageSong;
        private System.Windows.Forms.ToolStripMenuItem tsmSetSource;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmSearchSong;
        private System.Windows.Forms.ToolStripMenuItem tsmEditSong;
        private System.Windows.Forms.ToolStripMenuItem tsmSetPsource;
        private System.Windows.Forms.ToolStripMenuItem tsmSetSsource;
        private System.Windows.Forms.ToolStripMenuItem mstsmHelp;
    }
}