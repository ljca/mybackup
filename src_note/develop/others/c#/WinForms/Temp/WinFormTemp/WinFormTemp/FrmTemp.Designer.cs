namespace WinFormTemp
{
    partial class FrmTemp
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
            this.dgvTemp = new System.Windows.Forms.DataGridView();
            this.cboTemp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTemp
            // 
            this.dgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemp.Location = new System.Drawing.Point(8, 45);
            this.dgvTemp.Name = "dgvTemp";
            this.dgvTemp.RowTemplate.Height = 23;
            this.dgvTemp.Size = new System.Drawing.Size(703, 429);
            this.dgvTemp.TabIndex = 0;
            // 
            // cboTemp
            // 
            this.cboTemp.FormattingEnabled = true;
            this.cboTemp.Location = new System.Drawing.Point(8, 8);
            this.cboTemp.Name = "cboTemp";
            this.cboTemp.Size = new System.Drawing.Size(216, 20);
            this.cboTemp.TabIndex = 1;
            this.cboTemp.SelectedIndexChanged += new System.EventHandler(this.cboTemp_SelectedIndexChanged);
            // 
            // FrmTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 486);
            this.Controls.Add(this.cboTemp);
            this.Controls.Add(this.dgvTemp);
            this.Name = "FrmTemp";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.FrmTemp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemp;
        private System.Windows.Forms.ComboBox cboTemp;
    }
}

