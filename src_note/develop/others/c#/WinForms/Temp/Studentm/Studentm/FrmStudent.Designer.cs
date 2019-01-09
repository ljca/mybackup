namespace Studentm
{
    partial class FrmStudent
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
            this.txtstuemail = new System.Windows.Forms.TextBox();
            this.txtstuage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtstusex = new System.Windows.Forms.ComboBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtstuName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeach = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtstuemail);
            this.groupBox1.Controls.Add(this.txtstuage);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtstusex);
            this.groupBox1.Controls.Add(this.btnAct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据录入";
            // 
            // txtstuemail
            // 
            this.txtstuemail.Location = new System.Drawing.Point(493, 75);
            this.txtstuemail.Name = "txtstuemail";
            this.txtstuemail.Size = new System.Drawing.Size(253, 25);
            this.txtstuemail.TabIndex = 3;
            // 
            // txtstuage
            // 
            this.txtstuage.Location = new System.Drawing.Point(93, 75);
            this.txtstuage.Name = "txtstuage";
            this.txtstuage.Size = new System.Drawing.Size(253, 25);
            this.txtstuage.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 25);
            this.txtName.TabIndex = 3;
            // 
            // txtstusex
            // 
            this.txtstusex.FormattingEnabled = true;
            this.txtstusex.Location = new System.Drawing.Point(493, 24);
            this.txtstusex.Name = "txtstusex";
            this.txtstusex.Size = new System.Drawing.Size(253, 23);
            this.txtstusex.TabIndex = 5;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(807, 78);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(118, 39);
            this.btnAct.TabIndex = 4;
            this.btnAct.Text = "录入信息";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "邮箱：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "年龄：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtstuName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSeach);
            this.groupBox2.Location = new System.Drawing.Point(0, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据查询";
            // 
            // txtstuName
            // 
            this.txtstuName.Location = new System.Drawing.Point(93, 42);
            this.txtstuName.Name = "txtstuName";
            this.txtstuName.Size = new System.Drawing.Size(253, 25);
            this.txtstuName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "姓名：";
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(407, 33);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(110, 39);
            this.btnSeach.TabIndex = 4;
            this.btnSeach.Text = "查询";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudent.Location = new System.Drawing.Point(0, 208);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowTemplate.Height = 27;
            this.dgvStudent.Size = new System.Drawing.Size(969, 414);
            this.dgvStudent.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Stu_Id";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Stu_Name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Stu_Sex";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Stu_Age";
            this.Column4.HeaderText = "年龄";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Stu_Email";
            this.Column5.HeaderText = "邮箱";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 634);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStudent";
            this.Text = "学员信息录入";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox txtstusex;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstuemail;
        private System.Windows.Forms.TextBox txtstuage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstuName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}

