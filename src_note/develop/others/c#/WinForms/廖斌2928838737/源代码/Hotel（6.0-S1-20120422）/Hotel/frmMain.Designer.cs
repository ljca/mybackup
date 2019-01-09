namespace Hotel
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
            this.客房信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWeiHu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuiChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房信息ToolStripMenuItem,
            this.tsmiTuiChu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 客房信息ToolStripMenuItem
            // 
            this.客房信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWeiHu});
            this.客房信息ToolStripMenuItem.Name = "客房信息ToolStripMenuItem";
            this.客房信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客房信息ToolStripMenuItem.Text = "客房信息";
            // 
            // tsmiWeiHu
            // 
            this.tsmiWeiHu.Name = "tsmiWeiHu";
            this.tsmiWeiHu.Size = new System.Drawing.Size(152, 22);
            this.tsmiWeiHu.Text = "客房维护";
            this.tsmiWeiHu.Click += new System.EventHandler(this.tsmiWeiHu_Click);
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
            this.ClientSize = new System.Drawing.Size(826, 476);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客房管理信息系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 客房信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiWeiHu;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuiChu;
    }
}

