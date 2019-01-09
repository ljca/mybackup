namespace FrmTestWinfoms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tsTest = new System.Windows.Forms.ToolStrip();
            this.tsbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.stbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRelation = new System.Windows.Forms.ToolStripButton();
            this.cmsTest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmstsSingIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSingOut = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.tsTest.SuspendLayout();
            this.cmsTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTest.Location = new System.Drawing.Point(8, 90);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.RowTemplate.Height = 27;
            this.dgvTest.Size = new System.Drawing.Size(888, 418);
            this.dgvTest.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(534, 33);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(102, 35);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "查看";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "员工工号";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(340, 25);
            this.txtId.TabIndex = 3;
            // 
            // tsTest
            // 
            this.tsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSelect,
            this.stbtnUpdate,
            this.tsbtnDel,
            this.tsbtnRelation});
            this.tsTest.Location = new System.Drawing.Point(0, 0);
            this.tsTest.Name = "tsTest";
            this.tsTest.Size = new System.Drawing.Size(908, 27);
            this.tsTest.TabIndex = 4;
            this.tsTest.Text = "toolStrip1";
            // 
            // tsbtnSelect
            // 
            this.tsbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSelect.Image")));
            this.tsbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSelect.Name = "tsbtnSelect";
            this.tsbtnSelect.Size = new System.Drawing.Size(43, 24);
            this.tsbtnSelect.Text = "新增";
            this.tsbtnSelect.Click += new System.EventHandler(this.tsbtnSelect_Click);
            // 
            // stbtnUpdate
            // 
            this.stbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("stbtnUpdate.Image")));
            this.stbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtnUpdate.Name = "stbtnUpdate";
            this.stbtnUpdate.Size = new System.Drawing.Size(43, 24);
            this.stbtnUpdate.Text = "修改";
            // 
            // tsbtnDel
            // 
            this.tsbtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDel.Image")));
            this.tsbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDel.Name = "tsbtnDel";
            this.tsbtnDel.Size = new System.Drawing.Size(43, 24);
            this.tsbtnDel.Text = "删除";
            // 
            // tsbtnRelation
            // 
            this.tsbtnRelation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRelation.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRelation.Image")));
            this.tsbtnRelation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRelation.Name = "tsbtnRelation";
            this.tsbtnRelation.Size = new System.Drawing.Size(73, 24);
            this.tsbtnRelation.Text = "打卡记录";
            // 
            // cmsTest
            // 
            this.cmsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmstsSingIn,
            this.tsmSingOut});
            this.cmsTest.Name = "cmsTest";
            this.cmsTest.Size = new System.Drawing.Size(109, 52);
            // 
            // cmstsSingIn
            // 
            this.cmstsSingIn.Name = "cmstsSingIn";
            this.cmstsSingIn.Size = new System.Drawing.Size(108, 24);
            this.cmstsSingIn.Text = "签到";
            // 
            // tsmSingOut
            // 
            this.tsmSingOut.Name = "tsmSingOut";
            this.tsmSingOut.Size = new System.Drawing.Size(108, 24);
            this.tsmSingOut.Text = "签退";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 520);
            this.ContextMenuStrip = this.cmsTest;
            this.Controls.Add(this.tsTest);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvTest);
            this.Name = "FrmMain";
            this.Text = "测试类窗体";
            this.Load += new System.EventHandler(this.FrmTestWinForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.tsTest.ResumeLayout(false);
            this.tsTest.PerformLayout();
            this.cmsTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolStrip tsTest;
        private System.Windows.Forms.ToolStripButton tsbtnSelect;
        private System.Windows.Forms.ToolStripButton stbtnUpdate;
        private System.Windows.Forms.ToolStripButton tsbtnDel;
        private System.Windows.Forms.ToolStripButton tsbtnRelation;
        private System.Windows.Forms.ContextMenuStrip cmsTest;
        private System.Windows.Forms.ToolStripMenuItem cmstsSingIn;
        private System.Windows.Forms.ToolStripMenuItem tsmSingOut;
    }
}

