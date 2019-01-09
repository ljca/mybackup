namespace ExamSys
{
    partial class frmChaKan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXiuGai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShanChu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "考试日期：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamId,
            this.StuName,
            this.CourseName,
            this.Score,
            this.ExamDate,
            this.Remark});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(717, 308);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXiuGai,
            this.tsmiShanChu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiXiuGai
            // 
            this.tsmiXiuGai.Name = "tsmiXiuGai";
            this.tsmiXiuGai.Size = new System.Drawing.Size(100, 22);
            this.tsmiXiuGai.Text = "修改";
            this.tsmiXiuGai.Click += new System.EventHandler(this.tsmiXiuGai_Click);
            // 
            // tsmiShanChu
            // 
            this.tsmiShanChu.Name = "tsmiShanChu";
            this.tsmiShanChu.Size = new System.Drawing.Size(100, 22);
            this.tsmiShanChu.Text = "删除";
            // 
            // ExamId
            // 
            this.ExamId.DataPropertyName = "ExamId";
            this.ExamId.HeaderText = "学号";
            this.ExamId.Name = "ExamId";
            this.ExamId.ReadOnly = true;
            // 
            // StuName
            // 
            this.StuName.DataPropertyName = "StuName";
            this.StuName.HeaderText = "姓名";
            this.StuName.Name = "StuName";
            this.StuName.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "成绩";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // ExamDate
            // 
            this.ExamDate.DataPropertyName = "ExamDate";
            this.ExamDate.HeaderText = "考试日期";
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // frmChaKan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmChaKan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看考试信息";
            this.Load += new System.EventHandler(this.frmChaKan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiXiuGai;
        private System.Windows.Forms.ToolStripMenuItem tsmiShanChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}