namespace MyKTV
{
    partial class FrmOrderSongList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderSongList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsMusicPlay = new System.Windows.Forms.ToolStrip();
            this.tsbtnMain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnWhile = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCutsong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPlayed = new System.Windows.Forms.ToolStripButton();
            this.tsbtnServer = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsMusicPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 33);
            this.panel1.TabIndex = 8;
            // 
            // tsMusicPlay
            // 
            this.tsMusicPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMusicPlay.BackgroundImage")));
            this.tsMusicPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMusicPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMusicPlay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnMain,
            this.tsbtnWhile,
            this.tsbtnCutsong,
            this.tsbtnPlayed,
            this.tsbtnServer,
            this.tsbtnCancel});
            this.tsMusicPlay.Location = new System.Drawing.Point(0, 429);
            this.tsMusicPlay.Name = "tsMusicPlay";
            this.tsMusicPlay.Size = new System.Drawing.Size(854, 62);
            this.tsMusicPlay.TabIndex = 9;
            this.tsMusicPlay.Text = "歌曲播放";
            // 
            // tsbtnMain
            // 
            this.tsbtnMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMain.Image")));
            this.tsbtnMain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMain.Name = "tsbtnMain";
            this.tsbtnMain.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnMain.Size = new System.Drawing.Size(68, 59);
            this.tsbtnMain.Text = "主界面";
            this.tsbtnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnMain.Click += new System.EventHandler(this.tsbtnMain_Click);
            // 
            // tsbtnWhile
            // 
            this.tsbtnWhile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnWhile.Image")));
            this.tsbtnWhile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnWhile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnWhile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnWhile.Name = "tsbtnWhile";
            this.tsbtnWhile.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnWhile.Size = new System.Drawing.Size(53, 59);
            this.tsbtnWhile.Text = "重唱";
            this.tsbtnWhile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnWhile.ToolTipText = "主界面";
            this.tsbtnWhile.Click += new System.EventHandler(this.tsbtnWhile_Click);
            // 
            // tsbtnCutsong
            // 
            this.tsbtnCutsong.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCutsong.Image")));
            this.tsbtnCutsong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnCutsong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCutsong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCutsong.Margin = new System.Windows.Forms.Padding(0);
            this.tsbtnCutsong.Name = "tsbtnCutsong";
            this.tsbtnCutsong.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnCutsong.Size = new System.Drawing.Size(53, 62);
            this.tsbtnCutsong.Text = "切歌";
            this.tsbtnCutsong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCutsong.Click += new System.EventHandler(this.tsbtnCutsong_Click);
            // 
            // tsbtnPlayed
            // 
            this.tsbtnPlayed.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPlayed.Image")));
            this.tsbtnPlayed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnPlayed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnPlayed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPlayed.Name = "tsbtnPlayed";
            this.tsbtnPlayed.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbtnPlayed.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnPlayed.Size = new System.Drawing.Size(53, 59);
            this.tsbtnPlayed.Text = "已点";
            this.tsbtnPlayed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnPlayed.Click += new System.EventHandler(this.tsbtnPlayed_Click);
            // 
            // tsbtnServer
            // 
            this.tsbtnServer.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnServer.Image")));
            this.tsbtnServer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnServer.Name = "tsbtnServer";
            this.tsbtnServer.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnServer.Size = new System.Drawing.Size(53, 59);
            this.tsbtnServer.Text = "服务";
            this.tsbtnServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnServer.Click += new System.EventHandler(this.tsbtnServer_Click);
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnCancel.Size = new System.Drawing.Size(53, 59);
            this.tsbtnCancel.Text = "返回";
            this.tsbtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
            // 
            // FrmOrderSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.tsMusicPlay);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrderSongList";
            this.Text = "已点歌曲";
            this.Load += new System.EventHandler(this.FrmOrderSongList_Load);
            this.tsMusicPlay.ResumeLayout(false);
            this.tsMusicPlay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsMusicPlay;
        private System.Windows.Forms.ToolStripButton tsbtnMain;
        private System.Windows.Forms.ToolStripButton tsbtnWhile;
        private System.Windows.Forms.ToolStripButton tsbtnCutsong;
        private System.Windows.Forms.ToolStripButton tsbtnPlayed;
        private System.Windows.Forms.ToolStripButton tsbtnServer;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
    }
}