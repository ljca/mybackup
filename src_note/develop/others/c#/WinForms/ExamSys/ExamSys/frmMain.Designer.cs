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
            this.msExamInfo = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowEaxmInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddExamInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msExamInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // msExamInfo
            // 
            this.msExamInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.tsmExit});
            this.msExamInfo.Location = new System.Drawing.Point(0, 0);
            this.msExamInfo.Name = "msExamInfo";
            this.msExamInfo.Size = new System.Drawing.Size(860, 28);
            this.msExamInfo.TabIndex = 0;
            this.msExamInfo.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem1.Text = "系统管理";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowEaxmInfo,
            this.tsmAddExamInfo,
            this.tsmJInfo});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 24);
            this.toolStripMenuItem2.Text = "考试信息管理";
            // 
            // tsmShowEaxmInfo
            // 
            this.tsmShowEaxmInfo.Name = "tsmShowEaxmInfo";
            this.tsmShowEaxmInfo.Size = new System.Drawing.Size(168, 24);
            this.tsmShowEaxmInfo.Text = "查看考试信息";
            this.tsmShowEaxmInfo.Click += new System.EventHandler(this.tsmShowEaxmInfo_Click);
            // 
            // tsmAddExamInfo
            // 
            this.tsmAddExamInfo.Name = "tsmAddExamInfo";
            this.tsmAddExamInfo.Size = new System.Drawing.Size(168, 24);
            this.tsmAddExamInfo.Text = "录入考试信息";
            this.tsmAddExamInfo.Click += new System.EventHandler(this.tsmAddExamInfo_Click);
            // 
            // tsmJInfo
            // 
            this.tsmJInfo.Name = "tsmJInfo";
            this.tsmJInfo.Size = new System.Drawing.Size(168, 24);
            this.tsmJInfo.Text = "统计考试信息";
            this.tsmJInfo.Click += new System.EventHandler(this.tsmJInfo_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(51, 24);
            this.tsmExit.Text = "退出";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 498);
            this.Controls.Add(this.msExamInfo);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msExamInfo;
            this.Name = "frmMain";
            this.Text = "考试信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msExamInfo.ResumeLayout(false);
            this.msExamInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msExamInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmShowEaxmInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmAddExamInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmJInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
    }
}

