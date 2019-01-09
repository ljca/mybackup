namespace HealthCheck
{
    partial class FrmHeathCheck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddHeath = new System.Windows.Forms.Button();
            this.cboItemList = new System.Windows.Forms.ComboBox();
            this.dgvHeathItem = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeathItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddHeath);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新建套餐";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(98, 30);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(346, 25);
            this.txtItemName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "套餐名称";
            // 
            // btnAddHeath
            // 
            this.btnAddHeath.Location = new System.Drawing.Point(592, 26);
            this.btnAddHeath.Name = "btnAddHeath";
            this.btnAddHeath.Size = new System.Drawing.Size(94, 29);
            this.btnAddHeath.TabIndex = 1;
            this.btnAddHeath.Text = "添加";
            this.btnAddHeath.UseVisualStyleBackColor = true;
            this.btnAddHeath.Click += new System.EventHandler(this.btnAddHeath_Click);
            // 
            // cboItemList
            // 
            this.cboItemList.FormattingEnabled = true;
            this.cboItemList.Location = new System.Drawing.Point(97, 40);
            this.cboItemList.Name = "cboItemList";
            this.cboItemList.Size = new System.Drawing.Size(344, 23);
            this.cboItemList.TabIndex = 0;
            // 
            // dgvHeathItem
            // 
            this.dgvHeathItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeathItem.Location = new System.Drawing.Point(9, 188);
            this.dgvHeathItem.Name = "dgvHeathItem";
            this.dgvHeathItem.RowTemplate.Height = 27;
            this.dgvHeathItem.Size = new System.Drawing.Size(1008, 248);
            this.dgvHeathItem.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHeathItem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboItem);
            this.groupBox2.Controls.Add(this.cboItemList);
            this.groupBox2.Location = new System.Drawing.Point(3, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 442);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检查套餐维护";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "检查项目";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "套餐名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "套餐列表";
            // 
            // cboItem
            // 
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(589, 43);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(318, 23);
            this.cboItem.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(618, 88);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(94, 29);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "添加";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(813, 88);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "label1";
            // 
            // FrmHeathCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHeathCheck";
            this.Text = "体检套餐管理系统";
            this.Load += new System.EventHandler(this.FrmHeathCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeathItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHeathItem;
        private System.Windows.Forms.Button btnAddHeath;
        private System.Windows.Forms.ComboBox cboItemList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

