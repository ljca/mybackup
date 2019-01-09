namespace ExamSys
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
            this.考试信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChaKan = new System.Windows.Forms.ToolStripMenuItem();
            this.录入考试信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考试信息统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txmiTuiChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.考试信息管理ToolStripMenuItem,
            this.txmiTuiChu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 考试信息管理ToolStripMenuItem
            // 
            this.考试信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChaKan,
            this.录入考试信息ToolStripMenuItem,
            this.考试信息统计ToolStripMenuItem});
            this.考试信息管理ToolStripMenuItem.Name = "考试信息管理ToolStripMenuItem";
            this.考试信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.考试信息管理ToolStripMenuItem.Text = "考试信息管理";
            // 
            // tsmiChaKan
            // 
            this.tsmiChaKan.Name = "tsmiChaKan";
            this.tsmiChaKan.Size = new System.Drawing.Size(152, 22);
            this.tsmiChaKan.Text = "查看考试信息";
            this.tsmiChaKan.Click += new System.EventHandler(this.tsmiChaKan_Click);
            // 
            // 录入考试信息ToolStripMenuItem
            // 
            this.录入考试信息ToolStripMenuItem.Name = "录入考试信息ToolStripMenuItem";
            this.录入考试信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.录入考试信息ToolStripMenuItem.Text = "录入考试信息";
            // 
            // 考试信息统计ToolStripMenuItem
            // 
            this.考试信息统计ToolStripMenuItem.Name = "考试信息统计ToolStripMenuItem";
            this.考试信息统计ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.考试信息统计ToolStripMenuItem.Text = "考试信息统计";
            // 
            // txmiTuiChu
            // 
            this.txmiTuiChu.Name = "txmiTuiChu";
            this.txmiTuiChu.Size = new System.Drawing.Size(44, 21);
            this.txmiTuiChu.Text = "退出";
            this.txmiTuiChu.Click += new System.EventHandler(this.txmiTuiChu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 396);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "考试信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiChaKan;
        private System.Windows.Forms.ToolStripMenuItem 录入考试信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试信息统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txmiTuiChu;
    }
}

