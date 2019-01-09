namespace Chearcs
{
    partial class FormsAdmi
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "磁盘a",
            "30M",
            "c,d,e,f,g",
            "iso,img,bin...",
            "C:\\*.cmd",
            "20M"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("磁盘b", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("磁盘c", 6);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("磁盘d", 7);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("磁盘e", 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsAdmi));
            this.lvC = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTm1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tM_Large = new System.Windows.Forms.ToolStripMenuItem();
            this.tM_Small = new System.Windows.Forms.ToolStripMenuItem();
            this.tM_Tile = new System.Windows.Forms.ToolStripMenuItem();
            this.tM_Detail = new System.Windows.Forms.ToolStripMenuItem();
            this.tM_List = new System.Windows.Forms.ToolStripMenuItem();
            this.iLLarge = new System.Windows.Forms.ImageList(this.components);
            this.iLSamll = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cTm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvC
            // 
            this.lvC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvC.ContextMenuStrip = this.cTm1;
            listViewItem2.ToolTipText = "磁盘b";
            this.lvC.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lvC.LargeImageList = this.iLLarge;
            this.lvC.Location = new System.Drawing.Point(1, 12);
            this.lvC.Name = "lvC";
            this.lvC.Size = new System.Drawing.Size(623, 314);
            this.lvC.SmallImageList = this.iLSamll;
            this.lvC.TabIndex = 0;
            this.lvC.UseCompatibleStateImageBehavior = false;
            this.lvC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "磁盘";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "已用";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "分区";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "镜像文件";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "文件";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "未使用";
            this.columnHeader6.Width = 291;
            // 
            // cTm1
            // 
            this.cTm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tM_Large,
            this.tM_Small,
            this.tM_Tile,
            this.tM_Detail,
            this.tM_List});
            this.cTm1.Name = "cTm1";
            this.cTm1.Size = new System.Drawing.Size(124, 124);
            this.cTm1.Click += new System.EventHandler(this.tM_1_Click);
            // 
            // tM_Large
            // 
            this.tM_Large.Name = "tM_Large";
            this.tM_Large.Size = new System.Drawing.Size(123, 24);
            this.tM_Large.Text = "大图标";
            // 
            // tM_Small
            // 
            this.tM_Small.Name = "tM_Small";
            this.tM_Small.Size = new System.Drawing.Size(123, 24);
            this.tM_Small.Text = "小图标";
            this.tM_Small.Click += new System.EventHandler(this.tM_2_Click);
            // 
            // tM_Tile
            // 
            this.tM_Tile.Name = "tM_Tile";
            this.tM_Tile.Size = new System.Drawing.Size(123, 24);
            this.tM_Tile.Text = "详情";
            this.tM_Tile.Click += new System.EventHandler(this.tM_3_Click);
            // 
            // tM_Detail
            // 
            this.tM_Detail.Name = "tM_Detail";
            this.tM_Detail.Size = new System.Drawing.Size(123, 24);
            this.tM_Detail.Text = "平铺";
            this.tM_Detail.Click += new System.EventHandler(this.tM_4_Click);
            // 
            // tM_List
            // 
            this.tM_List.Name = "tM_List";
            this.tM_List.Size = new System.Drawing.Size(123, 24);
            this.tM_List.Text = "列表";
            this.tM_List.Click += new System.EventHandler(this.tM_5_Click);
            // 
            // iLLarge
            // 
            this.iLLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLLarge.ImageStream")));
            this.iLLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.iLLarge.Images.SetKeyName(0, "Chrysanthemum.jpg");
            this.iLLarge.Images.SetKeyName(1, "Desert.jpg");
            this.iLLarge.Images.SetKeyName(2, "Hydrangeas.jpg");
            this.iLLarge.Images.SetKeyName(3, "Jellyfish.jpg");
            this.iLLarge.Images.SetKeyName(4, "Koala.jpg");
            this.iLLarge.Images.SetKeyName(5, "Lighthouse.jpg");
            this.iLLarge.Images.SetKeyName(6, "Penguins.jpg");
            this.iLLarge.Images.SetKeyName(7, "Tulips.jpg");
            // 
            // iLSamll
            // 
            this.iLSamll.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLSamll.ImageStream")));
            this.iLSamll.TransparentColor = System.Drawing.Color.Transparent;
            this.iLSamll.Images.SetKeyName(0, "Chrysanthemum.jpg");
            this.iLSamll.Images.SetKeyName(1, "Desert.jpg");
            this.iLSamll.Images.SetKeyName(2, "Hydrangeas.jpg");
            this.iLSamll.Images.SetKeyName(3, "Jellyfish.jpg");
            this.iLSamll.Images.SetKeyName(4, "Koala.jpg");
            this.iLSamll.Images.SetKeyName(5, "Lighthouse.jpg");
            this.iLSamll.Images.SetKeyName(6, "Penguins.jpg");
            this.iLSamll.Images.SetKeyName(7, "Tulips.jpg");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // FormsAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 429);
            this.Controls.Add(this.lvC);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormsAdmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成熟了";
            this.Load += new System.EventHandler(this.FormsAdmi_Load);
            this.cTm1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvC;
        private System.Windows.Forms.ImageList iLLarge;
        private System.Windows.Forms.ImageList iLSamll;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip cTm1;
        private System.Windows.Forms.ToolStripMenuItem tM_Large;
        private System.Windows.Forms.ToolStripMenuItem tM_Small;
        private System.Windows.Forms.ToolStripMenuItem tM_Tile;
        private System.Windows.Forms.ToolStripMenuItem tM_Detail;
        private System.Windows.Forms.ToolStripMenuItem tM_List;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

