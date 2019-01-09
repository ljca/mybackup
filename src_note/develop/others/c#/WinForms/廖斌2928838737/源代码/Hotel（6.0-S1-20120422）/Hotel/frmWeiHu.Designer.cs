namespace Hotel
{
    partial class frmWeiHu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeiHu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShanChu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTuiChu = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberSelect = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBeds = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.Namber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbtnShanChu,
            this.toolStripButton3,
            this.tsbtnTuiChu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(622, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "新增";
            // 
            // tsbtnShanChu
            // 
            this.tsbtnShanChu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShanChu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShanChu.Image")));
            this.tsbtnShanChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShanChu.Name = "tsbtnShanChu";
            this.tsbtnShanChu.Size = new System.Drawing.Size(36, 22);
            this.tsbtnShanChu.Text = "删除";
            this.tsbtnShanChu.Click += new System.EventHandler(this.tsbtnShanChu_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton3.Text = "保存";
            // 
            // tsbtnTuiChu
            // 
            this.tsbtnTuiChu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnTuiChu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTuiChu.Image")));
            this.tsbtnTuiChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTuiChu.Name = "tsbtnTuiChu";
            this.tsbtnTuiChu.Size = new System.Drawing.Size(36, 22);
            this.tsbtnTuiChu.Text = "退出";
            this.tsbtnTuiChu.Click += new System.EventHandler(this.tsbtnTuiChu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "房间号：";
            // 
            // txtNumberSelect
            // 
            this.txtNumberSelect.Location = new System.Drawing.Point(188, 42);
            this.txtNumberSelect.Name = "txtNumberSelect";
            this.txtNumberSelect.Size = new System.Drawing.Size(246, 21);
            this.txtNumberSelect.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namber,
            this.Beds,
            this.Price,
            this.Remark});
            this.dgvData.Location = new System.Drawing.Point(12, 80);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(598, 183);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "客房号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "床位数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "备注";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(69, 281);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(127, 21);
            this.txtNumber.TabIndex = 6;
            // 
            // txtBeds
            // 
            this.txtBeds.Location = new System.Drawing.Point(281, 281);
            this.txtBeds.Name = "txtBeds";
            this.txtBeds.Size = new System.Drawing.Size(127, 21);
            this.txtBeds.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(485, 281);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 21);
            this.txtPrice.TabIndex = 6;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(69, 320);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(541, 51);
            this.txtRemark.TabIndex = 6;
            // 
            // Namber
            // 
            this.Namber.DataPropertyName = "Namber";
            this.Namber.HeaderText = "客房号";
            this.Namber.Name = "Namber";
            this.Namber.ReadOnly = true;
            // 
            // Beds
            // 
            this.Beds.DataPropertyName = "Beds";
            this.Beds.HeaderText = "床位数";
            this.Beds.Name = "Beds";
            this.Beds.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // frmWeiHu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 393);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtBeds);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumberSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmWeiHu";
            this.Text = "客房维护";
            this.Load += new System.EventHandler(this.frmWeiHu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnShanChu;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsbtnTuiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBeds;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;

    }
}