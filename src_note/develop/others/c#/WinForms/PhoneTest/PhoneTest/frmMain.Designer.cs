namespace PhoneTest
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
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电话卡销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meShowInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.增加电话卡销售记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.电话卡销售管理ToolStripMenuItem,
            this.meExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 电话卡销售管理ToolStripMenuItem
            // 
            this.电话卡销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meShowInfo,
            this.增加电话卡销售记录ToolStripMenuItem});
            this.电话卡销售管理ToolStripMenuItem.Name = "电话卡销售管理ToolStripMenuItem";
            this.电话卡销售管理ToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.电话卡销售管理ToolStripMenuItem.Text = "电话卡销售管理";
            // 
            // meShowInfo
            // 
            this.meShowInfo.Name = "meShowInfo";
            this.meShowInfo.Size = new System.Drawing.Size(213, 24);
            this.meShowInfo.Text = "查看电话卡销售信息";
            this.meShowInfo.Click += new System.EventHandler(this.meShowInfo_Click);
            // 
            // 增加电话卡销售记录ToolStripMenuItem
            // 
            this.增加电话卡销售记录ToolStripMenuItem.Name = "增加电话卡销售记录ToolStripMenuItem";
            this.增加电话卡销售记录ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.增加电话卡销售记录ToolStripMenuItem.Text = "增加电话卡销售记录";
            // 
            // meExit
            // 
            this.meExit.Name = "meExit";
            this.meExit.Size = new System.Drawing.Size(51, 24);
            this.meExit.Text = "退出";
            this.meExit.Click += new System.EventHandler(this.meExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 578);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电话卡管理销售系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电话卡销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meShowInfo;
        private System.Windows.Forms.ToolStripMenuItem 增加电话卡销售记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meExit;
    }
}

