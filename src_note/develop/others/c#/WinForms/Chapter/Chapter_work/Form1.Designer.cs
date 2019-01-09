namespace Chapter_work
{
    partial class Form1
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
            this.lvSE = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvSE
            // 
            this.lvSE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSE.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSE.Location = new System.Drawing.Point(0, 0);
            this.lvSE.Name = "lvSE";
            this.lvSE.Size = new System.Drawing.Size(522, 350);
            this.lvSE.TabIndex = 0;
            this.lvSE.UseCompatibleStateImageBehavior = false;
            this.lvSE.View = System.Windows.Forms.View.Details;
            this.lvSE.DoubleClick += new System.EventHandler(this.lvSE_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "工号";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "年龄";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "评价";
            this.columnHeader4.Width = 169;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "年度得分";
            this.columnHeader5.Width = 103;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 350);
            this.Controls.Add(this.lvSE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSE;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

