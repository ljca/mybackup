namespace AirQuality
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiLuRu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChaXun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuiChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLuRu,
            this.tsmiChaXun,
            this.tsmiTuiChu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.tsmiTuiChu;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiLuRu
            // 
            this.tsmiLuRu.Name = "tsmiLuRu";
            this.tsmiLuRu.Size = new System.Drawing.Size(92, 21);
            this.tsmiLuRu.Text = "录入检测数据";
            this.tsmiLuRu.Click += new System.EventHandler(this.tsmiLuRu_Click);
            // 
            // tsmiChaXun
            // 
            this.tsmiChaXun.Name = "tsmiChaXun";
            this.tsmiChaXun.Size = new System.Drawing.Size(92, 21);
            this.tsmiChaXun.Text = "查询检测数据";
            this.tsmiChaXun.Click += new System.EventHandler(this.tsmiChaXun_Click);
            // 
            // tsmiTuiChu
            // 
            this.tsmiTuiChu.Name = "tsmiTuiChu";
            this.tsmiTuiChu.Size = new System.Drawing.Size(44, 21);
            this.tsmiTuiChu.Text = "退出";
            this.tsmiTuiChu.Click += new System.EventHandler(this.tsmiTuiChu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 426);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "空气质量检测管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLuRu;
        private System.Windows.Forms.ToolStripMenuItem tsmiChaXun;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuiChu;
    }
}

