namespace MyKTV
{
    partial class FrmOrdereByWordCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdereByWordCount));
            this.tsMusicPlay = new System.Windows.Forms.ToolStrip();
            this.tsbtnMain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnWhile = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCutsong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPlayed = new System.Windows.Forms.ToolStripButton();
            this.tsbtnServer = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbwordsone = new System.Windows.Forms.Label();
            this.lbwordstwo = new System.Windows.Forms.Label();
            this.lbwordsthree = new System.Windows.Forms.Label();
            this.lbwordsfor = new System.Windows.Forms.Label();
            this.lbwordsfive = new System.Windows.Forms.Label();
            this.tsMusicPlay.SuspendLayout();
            this.SuspendLayout();
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
            this.tsMusicPlay.Location = new System.Drawing.Point(0, 443);
            this.tsMusicPlay.Name = "tsMusicPlay";
            this.tsMusicPlay.Size = new System.Drawing.Size(831, 62);
            this.tsMusicPlay.TabIndex = 9;
            this.tsMusicPlay.Text = "歌曲播放";
            // 
            // tsbtnMain
            // 
            this.tsbtnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.tsbtnWhile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.tsbtnCutsong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.tsbtnPlayed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.tsbtnServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.tsbtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 33);
            this.panel1.TabIndex = 10;
            // 
            // lbwordsone
            // 
            this.lbwordsone.AutoSize = true;
            this.lbwordsone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbwordsone.Image = global::MyKTV.Properties.Resources.bg05;
            this.lbwordsone.Location = new System.Drawing.Point(103, 93);
            this.lbwordsone.Name = "lbwordsone";
            this.lbwordsone.Size = new System.Drawing.Size(52, 15);
            this.lbwordsone.TabIndex = 11;
            this.lbwordsone.Text = "一个字";
            this.lbwordsone.Click += new System.EventHandler(this.lbwordsone_Click);
            this.lbwordsone.MouseHover += new System.EventHandler(this.lbwordsone_MouseHover);
            // 
            // lbwordstwo
            // 
            this.lbwordstwo.AutoSize = true;
            this.lbwordstwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbwordstwo.Image = global::MyKTV.Properties.Resources.bg05;
            this.lbwordstwo.Location = new System.Drawing.Point(194, 93);
            this.lbwordstwo.Name = "lbwordstwo";
            this.lbwordstwo.Size = new System.Drawing.Size(52, 15);
            this.lbwordstwo.TabIndex = 12;
            this.lbwordstwo.Text = "两个字";
            this.lbwordstwo.Click += new System.EventHandler(this.lbwordstwo_Click);
            this.lbwordstwo.MouseHover += new System.EventHandler(this.lbwordstwo_MouseHover);
            // 
            // lbwordsthree
            // 
            this.lbwordsthree.AutoSize = true;
            this.lbwordsthree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbwordsthree.Image = global::MyKTV.Properties.Resources.bg05;
            this.lbwordsthree.Location = new System.Drawing.Point(103, 154);
            this.lbwordsthree.Name = "lbwordsthree";
            this.lbwordsthree.Size = new System.Drawing.Size(52, 15);
            this.lbwordsthree.TabIndex = 13;
            this.lbwordsthree.Text = "三个字";
            this.lbwordsthree.Click += new System.EventHandler(this.lbwordsthree_Click);
            this.lbwordsthree.MouseHover += new System.EventHandler(this.lbwordsthree_MouseHover);
            // 
            // lbwordsfor
            // 
            this.lbwordsfor.AutoSize = true;
            this.lbwordsfor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbwordsfor.Image = global::MyKTV.Properties.Resources.bg05;
            this.lbwordsfor.Location = new System.Drawing.Point(185, 154);
            this.lbwordsfor.Name = "lbwordsfor";
            this.lbwordsfor.Size = new System.Drawing.Size(52, 15);
            this.lbwordsfor.TabIndex = 14;
            this.lbwordsfor.Text = "四个字";
            this.lbwordsfor.Click += new System.EventHandler(this.lbwordsfor_Click);
            this.lbwordsfor.MouseHover += new System.EventHandler(this.lbwordsfor_MouseHover);
            // 
            // lbwordsfive
            // 
            this.lbwordsfive.AutoSize = true;
            this.lbwordsfive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbwordsfive.Image = global::MyKTV.Properties.Resources.bg05;
            this.lbwordsfive.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbwordsfive.Location = new System.Drawing.Point(103, 230);
            this.lbwordsfive.Name = "lbwordsfive";
            this.lbwordsfive.Size = new System.Drawing.Size(52, 15);
            this.lbwordsfive.TabIndex = 15;
            this.lbwordsfive.Text = "五个字";
            this.lbwordsfive.Click += new System.EventHandler(this.lbwordsfive_Click);
            this.lbwordsfive.MouseHover += new System.EventHandler(this.lbwordsfive_MouseHover);
            // 
            // FrmOrdereByWordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 505);
            this.Controls.Add(this.lbwordsfive);
            this.Controls.Add(this.lbwordsfor);
            this.Controls.Add(this.lbwordsthree);
            this.Controls.Add(this.lbwordstwo);
            this.Controls.Add(this.lbwordsone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMusicPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrdereByWordCount";
            this.Text = "字数点歌";
            this.Load += new System.EventHandler(this.FrmOrdereByWordCount_Load);
            this.tsMusicPlay.ResumeLayout(false);
            this.tsMusicPlay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMusicPlay;
        private System.Windows.Forms.ToolStripButton tsbtnMain;
        private System.Windows.Forms.ToolStripButton tsbtnWhile;
        private System.Windows.Forms.ToolStripButton tsbtnCutsong;
        private System.Windows.Forms.ToolStripButton tsbtnPlayed;
        private System.Windows.Forms.ToolStripButton tsbtnServer;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbwordsone;
        private System.Windows.Forms.Label lbwordstwo;
        private System.Windows.Forms.Label lbwordsthree;
        private System.Windows.Forms.Label lbwordsfor;
        private System.Windows.Forms.Label lbwordsfive;
    }
}