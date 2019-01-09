namespace MySchoo
{
    partial class AdminForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForms));
            this.CtxM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.tMS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsS = new System.Windows.Forms.ToolStrip();
            this.tBtnAdd = new System.Windows.Forms.ToolStripSplitButton();
            this.tBtnSelect = new System.Windows.Forms.ToolStripSplitButton();
            this.tBtnUpdate = new System.Windows.Forms.ToolStripSplitButton();
            this.iLBig = new System.Windows.Forms.ImageList(this.components);
            this.iLSmall = new System.Windows.Forms.ImageList(this.components);
            this.Menu.SuspendLayout();
            this.tsS.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtxM
            // 
            this.CtxM.Name = "CtxM";
            this.CtxM.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMS,
            this.tsE,
            this.tsEdit_Data,
            this.tmsWindow,
            this.tmExit});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.MdiWindowListItem = this.tmsWindow;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(878, 28);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "MenuT";
            // 
            // tMS
            // 
            this.tMS.Name = "tMS";
            this.tMS.Size = new System.Drawing.Size(66, 24);
            this.tMS.Text = "管理员";
            // 
            // tsE
            // 
            this.tsE.Name = "tsE";
            this.tsE.Size = new System.Drawing.Size(51, 24);
            this.tsE.Text = "新建";
            // 
            // tsEdit_Data
            // 
            this.tsEdit_Data.Name = "tsEdit_Data";
            this.tsEdit_Data.Size = new System.Drawing.Size(96, 24);
            this.tsEdit_Data.Text = "数据库操作";
            // 
            // tmsWindow
            // 
            this.tmsWindow.Name = "tmsWindow";
            this.tmsWindow.Size = new System.Drawing.Size(51, 24);
            this.tmsWindow.Text = "窗口";
            // 
            // tmExit
            // 
            this.tmExit.Name = "tmExit";
            this.tmExit.Size = new System.Drawing.Size(51, 24);
            this.tmExit.Text = "退出";
            this.tmExit.Click += new System.EventHandler(this.tmExit_Click);
            // 
            // tsS
            // 
            this.tsS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBtnAdd,
            this.tBtnSelect,
            this.tBtnUpdate});
            this.tsS.Location = new System.Drawing.Point(0, 28);
            this.tsS.Name = "tsS";
            this.tsS.Size = new System.Drawing.Size(878, 27);
            this.tsS.TabIndex = 5;
            this.tsS.Text = "toolStrip1";
            // 
            // tBtnAdd
            // 
            this.tBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tBtnAdd.Image")));
            this.tBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnAdd.Name = "tBtnAdd";
            this.tBtnAdd.Size = new System.Drawing.Size(101, 24);
            this.tBtnAdd.Text = "新增学生";
            this.tBtnAdd.ButtonClick += new System.EventHandler(this.tBtnAdd_ButtonClick);
            // 
            // tBtnSelect
            // 
            this.tBtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("tBtnSelect.Image")));
            this.tBtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnSelect.Name = "tBtnSelect";
            this.tBtnSelect.Size = new System.Drawing.Size(71, 25);
            this.tBtnSelect.Text = "查询";
            this.tBtnSelect.ButtonClick += new System.EventHandler(this.tBtnSelect_ButtonClick);
            // 
            // tBtnUpdate
            // 
            this.tBtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tBtnUpdate.Image")));
            this.tBtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnUpdate.Name = "tBtnUpdate";
            this.tBtnUpdate.Size = new System.Drawing.Size(101, 25);
            this.tBtnUpdate.Text = "更新数据";
            // 
            // iLBig
            // 
            this.iLBig.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iLBig.ImageSize = new System.Drawing.Size(16, 16);
            this.iLBig.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // iLSmall
            // 
            this.iLSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iLSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.iLSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AdminForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 561);
            this.Controls.Add(this.tsS);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "AdminForms";
            this.Text = "管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.tsS.ResumeLayout(false);
            this.tsS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CtxM;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem tMS;
        private System.Windows.Forms.ToolStripMenuItem tsE;
        private System.Windows.Forms.ToolStripMenuItem tsEdit_Data;
        private System.Windows.Forms.ToolStripMenuItem tmsWindow;
        private System.Windows.Forms.ToolStripMenuItem tmExit;
        private System.Windows.Forms.ToolStrip tsS;
        private System.Windows.Forms.ToolStripSplitButton tBtnAdd;
        private System.Windows.Forms.ToolStripSplitButton tBtnSelect;
        private System.Windows.Forms.ToolStripSplitButton tBtnUpdate;
        private System.Windows.Forms.ImageList iLBig;
        private System.Windows.Forms.ImageList iLSmall;
    }
}

