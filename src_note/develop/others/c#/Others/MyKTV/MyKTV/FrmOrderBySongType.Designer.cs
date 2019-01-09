namespace MyKTV
{
    partial class FrmOrderBySongType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderBySongType));
            this.tsMusicPlay = new System.Windows.Forms.ToolStrip();
            this.tsbtnMain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnWhile = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCutsong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPlayed = new System.Windows.Forms.ToolStripButton();
            this.tsbtnServer = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSiner = new System.Windows.Forms.Label();
            this.lbJ = new System.Windows.Forms.Label();
            this.lbGame = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbOld = new System.Windows.Forms.Label();
            this.lbPop = new System.Windows.Forms.Label();
            this.pbtypeReuest = new System.Windows.Forms.PictureBox();
            this.pbabRequest = new System.Windows.Forms.PictureBox();
            this.pbsingerRequest = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tsMusicPlay.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtypeReuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbabRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsingerRequest)).BeginInit();
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
            this.tsMusicPlay.Location = new System.Drawing.Point(0, 494);
            this.tsMusicPlay.Name = "tsMusicPlay";
            this.tsMusicPlay.Size = new System.Drawing.Size(892, 62);
            this.tsMusicPlay.TabIndex = 11;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbSiner);
            this.panel1.Controls.Add(this.lbJ);
            this.panel1.Controls.Add(this.lbGame);
            this.panel1.Controls.Add(this.lbM);
            this.panel1.Controls.Add(this.lbOld);
            this.panel1.Controls.Add(this.lbPop);
            this.panel1.Controls.Add(this.pbtypeReuest);
            this.panel1.Controls.Add(this.pbabRequest);
            this.panel1.Controls.Add(this.pbsingerRequest);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 454);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(524, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lbSiner
            // 
            this.lbSiner.AutoSize = true;
            this.lbSiner.Image = global::MyKTV.Properties.Resources.bg08;
            this.lbSiner.Location = new System.Drawing.Point(571, 348);
            this.lbSiner.Name = "lbSiner";
            this.lbSiner.Size = new System.Drawing.Size(37, 15);
            this.lbSiner.TabIndex = 26;
            this.lbSiner.Text = "儿歌";
            // 
            // lbJ
            // 
            this.lbJ.AutoSize = true;
            this.lbJ.Image = global::MyKTV.Properties.Resources.bg08;
            this.lbJ.Location = new System.Drawing.Point(357, 348);
            this.lbJ.Name = "lbJ";
            this.lbJ.Size = new System.Drawing.Size(37, 15);
            this.lbJ.TabIndex = 25;
            this.lbJ.Text = "京剧";
            // 
            // lbGame
            // 
            this.lbGame.AutoSize = true;
            this.lbGame.Image = global::MyKTV.Properties.Resources.bg08;
            this.lbGame.Location = new System.Drawing.Point(135, 348);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(67, 15);
            this.lbGame.TabIndex = 24;
            this.lbGame.Text = "游戏动漫";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Image = global::MyKTV.Properties.Resources.bg08;
            this.lbM.Location = new System.Drawing.Point(541, 170);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(67, 15);
            this.lbM.TabIndex = 23;
            this.lbM.Text = "影视金曲";
            // 
            // lbOld
            // 
            this.lbOld.AutoSize = true;
            this.lbOld.Image = global::MyKTV.Properties.Resources.bg08;
            this.lbOld.Location = new System.Drawing.Point(357, 170);
            this.lbOld.Name = "lbOld";
            this.lbOld.Size = new System.Drawing.Size(67, 15);
            this.lbOld.TabIndex = 22;
            this.lbOld.Text = "经典老歌";
            // 
            // lbPop
            // 
            this.lbPop.AutoSize = true;
            this.lbPop.Image = global::MyKTV.Properties.Resources.bg08;
            this.lbPop.Location = new System.Drawing.Point(135, 170);
            this.lbPop.Name = "lbPop";
            this.lbPop.Size = new System.Drawing.Size(67, 15);
            this.lbPop.TabIndex = 21;
            this.lbPop.Text = "热门流行";
            // 
            // pbtypeReuest
            // 
            this.pbtypeReuest.Image = ((System.Drawing.Image)(resources.GetObject("pbtypeReuest.Image")));
            this.pbtypeReuest.Location = new System.Drawing.Point(524, 25);
            this.pbtypeReuest.Name = "pbtypeReuest";
            this.pbtypeReuest.Size = new System.Drawing.Size(133, 116);
            this.pbtypeReuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtypeReuest.TabIndex = 20;
            this.pbtypeReuest.TabStop = false;
            // 
            // pbabRequest
            // 
            this.pbabRequest.Image = ((System.Drawing.Image)(resources.GetObject("pbabRequest.Image")));
            this.pbabRequest.Location = new System.Drawing.Point(323, 25);
            this.pbabRequest.Name = "pbabRequest";
            this.pbabRequest.Size = new System.Drawing.Size(130, 116);
            this.pbabRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbabRequest.TabIndex = 19;
            this.pbabRequest.TabStop = false;
            // 
            // pbsingerRequest
            // 
            this.pbsingerRequest.Image = ((System.Drawing.Image)(resources.GetObject("pbsingerRequest.Image")));
            this.pbsingerRequest.Location = new System.Drawing.Point(113, 25);
            this.pbsingerRequest.Name = "pbsingerRequest";
            this.pbsingerRequest.Size = new System.Drawing.Size(127, 116);
            this.pbsingerRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsingerRequest.TabIndex = 18;
            this.pbsingerRequest.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 36);
            this.panel2.TabIndex = 30;
            // 
            // FrmOrderBySongType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMusicPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrderBySongType";
            this.Text = "分类点歌";
            this.Load += new System.EventHandler(this.FrmOrderBySongType_Load);
            this.tsMusicPlay.ResumeLayout(false);
            this.tsMusicPlay.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtypeReuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbabRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsingerRequest)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSiner;
        private System.Windows.Forms.Label lbJ;
        private System.Windows.Forms.Label lbGame;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbOld;
        private System.Windows.Forms.Label lbPop;
        private System.Windows.Forms.PictureBox pbtypeReuest;
        private System.Windows.Forms.PictureBox pbabRequest;
        private System.Windows.Forms.PictureBox pbsingerRequest;
        private System.Windows.Forms.Panel panel2;
    }
}