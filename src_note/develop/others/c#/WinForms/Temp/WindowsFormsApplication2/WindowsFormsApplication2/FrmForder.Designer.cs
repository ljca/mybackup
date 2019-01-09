namespace WindowsFormsApplication2
{
    partial class FrmForder
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
            this.msFolder = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvFolder = new System.Windows.Forms.TreeView();
            this.lvFolder = new System.Windows.Forms.ListView();
            this.msFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msFolder
            // 
            this.msFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.退出QToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.msFolder.Location = new System.Drawing.Point(0, 0);
            this.msFolder.Name = "msFolder";
            this.msFolder.Size = new System.Drawing.Size(840, 28);
            this.msFolder.TabIndex = 0;
            this.msFolder.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.新建ToolStripMenuItem.Text = "新建&";
            // 
            // 退出QToolStripMenuItem
            // 
            this.退出QToolStripMenuItem.Name = "退出QToolStripMenuItem";
            this.退出QToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.退出QToolStripMenuItem.Text = "退出(&Q)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvFolder);
            this.splitContainer1.Size = new System.Drawing.Size(840, 523);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvFolder
            // 
            this.tvFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFolder.Location = new System.Drawing.Point(0, 0);
            this.tvFolder.Name = "tvFolder";
            this.tvFolder.Size = new System.Drawing.Size(280, 523);
            this.tvFolder.TabIndex = 0;
            // 
            // lvFolder
            // 
            this.lvFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFolder.Location = new System.Drawing.Point(0, 0);
            this.lvFolder.Name = "lvFolder";
            this.lvFolder.Size = new System.Drawing.Size(556, 523);
            this.lvFolder.TabIndex = 1;
            this.lvFolder.UseCompatibleStateImageBehavior = false;
            // 
            // FrmForder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.msFolder);
            this.MainMenuStrip = this.msFolder;
            this.Name = "FrmForder";
            this.Text = "资源管理器";
            this.Load += new System.EventHandler(this.FrmForder_Load);
            this.msFolder.ResumeLayout(false);
            this.msFolder.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msFolder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvFolder;
        private System.Windows.Forms.ListView lvFolder;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
    }
}

