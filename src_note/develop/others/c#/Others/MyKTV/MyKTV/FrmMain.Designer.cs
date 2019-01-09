namespace MyKTV
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbwordsRquest = new System.Windows.Forms.PictureBox();
            this.pbCharts = new System.Windows.Forms.PictureBox();
            this.pbtypeReuest = new System.Windows.Forms.PictureBox();
            this.pbabRequest = new System.Windows.Forms.PictureBox();
            this.pbsingerRequest = new System.Windows.Forms.PictureBox();
            this.tsMusicPlay = new System.Windows.Forms.ToolStrip();
            this.tsbtnWhile = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCutsong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPlayed = new System.Windows.Forms.ToolStripButton();
            this.tsbtnServer = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbwordsRquest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtypeReuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbabRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsingerRequest)).BeginInit();
            this.tsMusicPlay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::MyKTV.Properties.Resources.tsMain_BackgroundImage;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "正在播放";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::MyKTV.Properties.Resources.tsMain_BackgroundImage;
            this.label2.Location = new System.Drawing.Point(429, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "下一曲";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(487, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 25);
            this.textBox2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pbwordsRquest);
            this.panel1.Controls.Add(this.pbCharts);
            this.panel1.Controls.Add(this.pbtypeReuest);
            this.panel1.Controls.Add(this.pbabRequest);
            this.panel1.Controls.Add(this.pbsingerRequest);
            this.panel1.Location = new System.Drawing.Point(131, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 317);
            this.panel1.TabIndex = 4;
            // 
            // pbwordsRquest
            // 
            this.pbwordsRquest.Image = ((System.Drawing.Image)(resources.GetObject("pbwordsRquest.Image")));
            this.pbwordsRquest.Location = new System.Drawing.Point(229, 189);
            this.pbwordsRquest.Name = "pbwordsRquest";
            this.pbwordsRquest.Size = new System.Drawing.Size(102, 98);
            this.pbwordsRquest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbwordsRquest.TabIndex = 22;
            this.pbwordsRquest.TabStop = false;
            this.pbwordsRquest.Click += new System.EventHandler(this.pbwordsRquest_Click);
            this.pbwordsRquest.MouseHover += new System.EventHandler(this.pbwordsRquest_MouseHover);
            // 
            // pbCharts
            // 
            this.pbCharts.Image = ((System.Drawing.Image)(resources.GetObject("pbCharts.Image")));
            this.pbCharts.Location = new System.Drawing.Point(72, 189);
            this.pbCharts.Name = "pbCharts";
            this.pbCharts.Size = new System.Drawing.Size(101, 98);
            this.pbCharts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharts.TabIndex = 21;
            this.pbCharts.TabStop = false;
            this.pbCharts.Click += new System.EventHandler(this.pbCharts_Click);
            this.pbCharts.MouseHover += new System.EventHandler(this.pbCharts_MouseHover);
            // 
            // pbtypeReuest
            // 
            this.pbtypeReuest.Image = ((System.Drawing.Image)(resources.GetObject("pbtypeReuest.Image")));
            this.pbtypeReuest.Location = new System.Drawing.Point(397, 44);
            this.pbtypeReuest.Name = "pbtypeReuest";
            this.pbtypeReuest.Size = new System.Drawing.Size(97, 98);
            this.pbtypeReuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtypeReuest.TabIndex = 20;
            this.pbtypeReuest.TabStop = false;
            this.pbtypeReuest.Click += new System.EventHandler(this.pbtypeReuest_Click);
            this.pbtypeReuest.MouseHover += new System.EventHandler(this.pbtypeReuest_MouseHover);
            // 
            // pbabRequest
            // 
            this.pbabRequest.Image = ((System.Drawing.Image)(resources.GetObject("pbabRequest.Image")));
            this.pbabRequest.Location = new System.Drawing.Point(229, 44);
            this.pbabRequest.Name = "pbabRequest";
            this.pbabRequest.Size = new System.Drawing.Size(102, 98);
            this.pbabRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbabRequest.TabIndex = 19;
            this.pbabRequest.TabStop = false;
            this.pbabRequest.Click += new System.EventHandler(this.pbabRequest_Click);
            this.pbabRequest.MouseHover += new System.EventHandler(this.pbabRequest_MouseHover);
            // 
            // pbsingerRequest
            // 
            this.pbsingerRequest.Image = ((System.Drawing.Image)(resources.GetObject("pbsingerRequest.Image")));
            this.pbsingerRequest.Location = new System.Drawing.Point(72, 44);
            this.pbsingerRequest.Name = "pbsingerRequest";
            this.pbsingerRequest.Size = new System.Drawing.Size(101, 98);
            this.pbsingerRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsingerRequest.TabIndex = 18;
            this.pbsingerRequest.TabStop = false;
            this.pbsingerRequest.Click += new System.EventHandler(this.pbsingerRequest_Click);
            this.pbsingerRequest.MouseHover += new System.EventHandler(this.pbsingerRequest_MouseHover);
            // 
            // tsMusicPlay
            // 
            this.tsMusicPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMusicPlay.BackgroundImage")));
            this.tsMusicPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMusicPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMusicPlay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnWhile,
            this.tsbtnCutsong,
            this.tsbtnPlayed,
            this.tsbtnServer,
            this.tsbtnExit});
            this.tsMusicPlay.Location = new System.Drawing.Point(0, 400);
            this.tsMusicPlay.Name = "tsMusicPlay";
            this.tsMusicPlay.Size = new System.Drawing.Size(855, 69);
            this.tsMusicPlay.TabIndex = 12;
            this.tsMusicPlay.Text = "歌曲播放";
            // 
            // tsbtnWhile
            // 
            this.tsbtnWhile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnWhile.Image")));
            this.tsbtnWhile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnWhile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnWhile.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbtnWhile.Name = "tsbtnWhile";
            this.tsbtnWhile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnWhile.Size = new System.Drawing.Size(63, 69);
            this.tsbtnWhile.Text = "重唱";
            this.tsbtnWhile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnWhile.ToolTipText = "单曲播放";
            this.tsbtnWhile.Click += new System.EventHandler(this.tsbtnWhile_Click);
            // 
            // tsbtnCutsong
            // 
            this.tsbtnCutsong.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCutsong.Image")));
            this.tsbtnCutsong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCutsong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCutsong.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbtnCutsong.Name = "tsbtnCutsong";
            this.tsbtnCutsong.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbtnCutsong.Size = new System.Drawing.Size(53, 69);
            this.tsbtnCutsong.Text = "切歌";
            this.tsbtnCutsong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCutsong.ToolTipText = "切换到下一首或上一首";
            this.tsbtnCutsong.Click += new System.EventHandler(this.tsbtnCutsong_Click);
            // 
            // tsbtnPlayed
            // 
            this.tsbtnPlayed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnPlayed.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPlayed.Image")));
            this.tsbtnPlayed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnPlayed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPlayed.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbtnPlayed.Name = "tsbtnPlayed";
            this.tsbtnPlayed.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnPlayed.Size = new System.Drawing.Size(63, 69);
            this.tsbtnPlayed.Text = "已点";
            this.tsbtnPlayed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnPlayed.ToolTipText = "显示已点歌曲";
            this.tsbtnPlayed.Click += new System.EventHandler(this.tsbtnPlayed_Click);
            // 
            // tsbtnServer
            // 
            this.tsbtnServer.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnServer.Image")));
            this.tsbtnServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnServer.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbtnServer.Name = "tsbtnServer";
            this.tsbtnServer.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.tsbtnServer.Size = new System.Drawing.Size(63, 69);
            this.tsbtnServer.Text = "服务";
            this.tsbtnServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnServer.ToolTipText = "后台管理";
            this.tsbtnServer.Click += new System.EventHandler(this.tsbtnServer_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnExit.Size = new System.Drawing.Size(63, 69);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.ToolTipText = "退出系统";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 42);
            this.panel2.TabIndex = 13;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tsMusicPlay);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "KTV点歌系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbwordsRquest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtypeReuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbabRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsingerRequest)).EndInit();
            this.tsMusicPlay.ResumeLayout(false);
            this.tsMusicPlay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsMusicPlay;
        private System.Windows.Forms.ToolStripButton tsbtnWhile;
        private System.Windows.Forms.ToolStripButton tsbtnCutsong;
        private System.Windows.Forms.ToolStripButton tsbtnPlayed;
        private System.Windows.Forms.ToolStripButton tsbtnServer;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.PictureBox pbwordsRquest;
        private System.Windows.Forms.PictureBox pbCharts;
        private System.Windows.Forms.PictureBox pbtypeReuest;
        private System.Windows.Forms.PictureBox pbabRequest;
        private System.Windows.Forms.PictureBox pbsingerRequest;
        private System.Windows.Forms.Panel panel2;
    }
}

