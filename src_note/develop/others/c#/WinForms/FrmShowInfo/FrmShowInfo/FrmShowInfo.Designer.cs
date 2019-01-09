namespace FrmShowInfo
{
    partial class FrmShowInfo
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsearh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(831, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(12, 12);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(632, 25);
            this.txtSingerName.TabIndex = 1;
            this.txtSingerName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSingerName_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "(支持模糊查询)";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(12, 82);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(632, 25);
            this.txtSongName.TabIndex = 1;
            this.txtSongName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSongName_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "(支持模糊查询)";
            // 
            // btnsearh
            // 
            this.btnsearh.Location = new System.Drawing.Point(831, 81);
            this.btnsearh.Name = "btnsearh";
            this.btnsearh.Size = new System.Drawing.Size(109, 26);
            this.btnsearh.TabIndex = 4;
            this.btnsearh.Text = "搜索";
            this.btnsearh.UseVisualStyleBackColor = true;
            this.btnsearh.Click += new System.EventHandler(this.btnsearh_Click);
            // 
            // FrmShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 512);
            this.Controls.Add(this.btnsearh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmShowInfo";
            this.Text = "搜索歌曲.....歌手..........";
            this.Load += new System.EventHandler(this.FrmShowInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsearh;
    }
}

