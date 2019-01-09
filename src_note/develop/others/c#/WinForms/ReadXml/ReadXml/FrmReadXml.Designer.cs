namespace ReadXml
{
    partial class FrmReadXml
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvHouse = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJieDao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLou = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHouseNuber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvHouse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtHouseNuber);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtLou);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtJu);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtJieDao);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(650, 358);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvHouse
            // 
            this.tvHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvHouse.Location = new System.Drawing.Point(0, 0);
            this.tvHouse.Name = "tvHouse";
            this.tvHouse.Size = new System.Drawing.Size(216, 358);
            this.tvHouse.TabIndex = 0;
            this.tvHouse.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvHouse_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "街道";
            // 
            // txtJieDao
            // 
            this.txtJieDao.Location = new System.Drawing.Point(85, 12);
            this.txtJieDao.Name = "txtJieDao";
            this.txtJieDao.Size = new System.Drawing.Size(232, 21);
            this.txtJieDao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "居委会";
            // 
            // txtJu
            // 
            this.txtJu.Location = new System.Drawing.Point(85, 74);
            this.txtJu.Name = "txtJu";
            this.txtJu.Size = new System.Drawing.Size(232, 21);
            this.txtJu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "楼号";
            // 
            // txtLou
            // 
            this.txtLou.Location = new System.Drawing.Point(85, 137);
            this.txtLou.Name = "txtLou";
            this.txtLou.Size = new System.Drawing.Size(232, 21);
            this.txtLou.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "房间号";
            // 
            // txtHouseNuber
            // 
            this.txtHouseNuber.Location = new System.Drawing.Point(85, 199);
            this.txtHouseNuber.Name = "txtHouseNuber";
            this.txtHouseNuber.Size = new System.Drawing.Size(232, 21);
            this.txtHouseNuber.TabIndex = 1;
            // 
            // FrmReadXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 358);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmReadXml";
            this.Text = "街道管理";
            this.Load += new System.EventHandler(this.FrmReadXml_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvHouse;
        private System.Windows.Forms.TextBox txtJieDao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHouseNuber;
        private System.Windows.Forms.Label label4;
    }
}

