namespace BoardScheduleManager
{
    partial class MainForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiBoardroomManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNoteManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBoardroomManage,
            this.tsmiNoteManage,
            this.tsmiExit});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(566, 25);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiBoardroomManage
            // 
            this.tsmiBoardroomManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBookRoom,
            this.tsmiSelect});
            this.tsmiBoardroomManage.Name = "tsmiBoardroomManage";
            this.tsmiBoardroomManage.Size = new System.Drawing.Size(80, 21);
            this.tsmiBoardroomManage.Text = "会议室管理";
            // 
            // tsmiBookRoom
            // 
            this.tsmiBookRoom.Name = "tsmiBookRoom";
            this.tsmiBookRoom.Size = new System.Drawing.Size(152, 22);
            this.tsmiBookRoom.Text = "预定会议室";
            this.tsmiBookRoom.Click += new System.EventHandler(this.tsmiBookRoom_Click);
            // 
            // tsmiSelect
            // 
            this.tsmiSelect.Name = "tsmiSelect";
            this.tsmiSelect.Size = new System.Drawing.Size(152, 22);
            this.tsmiSelect.Text = "查询预定情况";
            this.tsmiSelect.Click += new System.EventHandler(this.tsmiSelect_Click);
            // 
            // tsmiNoteManage
            // 
            this.tsmiNoteManage.Name = "tsmiNoteManage";
            this.tsmiNoteManage.Size = new System.Drawing.Size(92, 21);
            this.tsmiNoteManage.Text = "会议纪要管理";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(68, 21);
            this.tsmiExit.Text = "退出系统";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(566, 387);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.Text = "会议室预定系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiBoardroomManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelect;
        private System.Windows.Forms.ToolStripMenuItem tsmiNoteManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

