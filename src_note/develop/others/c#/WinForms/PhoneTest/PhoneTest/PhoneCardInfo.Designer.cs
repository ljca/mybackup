namespace PhoneTest
{
    partial class PhoneCardInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSaleInfo = new System.Windows.Forms.DataGridView();
            this.cmInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmUp = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInfo)).BeginInit();
            this.cmInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSaleInfo
            // 
            this.dgvSaleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvSaleInfo.ContextMenuStrip = this.cmInfo;
            this.dgvSaleInfo.Location = new System.Drawing.Point(2, 12);
            this.dgvSaleInfo.Name = "dgvSaleInfo";
            this.dgvSaleInfo.RowTemplate.Height = 27;
            this.dgvSaleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleInfo.Size = new System.Drawing.Size(883, 469);
            this.dgvSaleInfo.TabIndex = 0;
            // 
            // cmInfo
            // 
            this.cmInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmUp,
            this.删除ToolStripMenuItem});
            this.cmInfo.Name = "cmInfo";
            this.cmInfo.Size = new System.Drawing.Size(109, 52);
            // 
            // ctmUp
            // 
            this.ctmUp.Name = "ctmUp";
            this.ctmUp.Size = new System.Drawing.Size(108, 24);
            this.ctmUp.Text = "修改";
            this.ctmUp.Click += new System.EventHandler(this.ctmUp_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // Column1
            // 
            this.Column1.ContextMenuStrip = this.cmInfo;
            this.Column1.DataPropertyName = "SaleId";
            this.Column1.HeaderText = "销售编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.ContextMenuStrip = this.cmInfo;
            this.Column2.DataPropertyName = "PhoneCardId";
            this.Column2.HeaderText = "电话卡编号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.ContextMenuStrip = this.cmInfo;
            this.Column3.DataPropertyName = "SaleCount";
            this.Column3.HeaderText = "销售数量";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.ContextMenuStrip = this.cmInfo;
            this.Column4.DataPropertyName = "SaleDate";
            this.Column4.HeaderText = "销售日期";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.ContextMenuStrip = this.cmInfo;
            this.Column5.DataPropertyName = "SalePrice";
            this.Column5.HeaderText = "单价";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.ContextMenuStrip = this.cmInfo;
            this.Column6.DataPropertyName = "Remark";
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            // 
            // ShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 524);
            this.Controls.Add(this.dgvSaleInfo);
            this.MaximizeBox = false;
            this.Name = "ShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看电话卡销售信息";
            this.Load += new System.EventHandler(this.ShowInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInfo)).EndInit();
            this.cmInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaleInfo;
        private System.Windows.Forms.ContextMenuStrip cmInfo;
        private System.Windows.Forms.ToolStripMenuItem ctmUp;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}