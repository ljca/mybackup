namespace ExamSys
{
    partial class FrmShowInfo
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmsRevise = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRevise = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtExamDate = new System.Windows.Forms.TextBox();
            this.dgvShowInfo = new System.Windows.Forms.DataGridView();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRevise.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(774, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmsRevise
            // 
            this.cmsRevise.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRevise});
            this.cmsRevise.Name = "cmsRevise";
            this.cmsRevise.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmiRevise
            // 
            this.tsmiRevise.Name = "tsmiRevise";
            this.tsmiRevise.Size = new System.Drawing.Size(108, 24);
            this.tsmiRevise.Text = "修改";
            this.tsmiRevise.Click += new System.EventHandler(this.tsmiRevise_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtExamDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "考试日期";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(467, 21);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(275, 25);
            this.txtStudentName.TabIndex = 0;
            // 
            // txtExamDate
            // 
            this.txtExamDate.Location = new System.Drawing.Point(105, 21);
            this.txtExamDate.Name = "txtExamDate";
            this.txtExamDate.Size = new System.Drawing.Size(275, 25);
            this.txtExamDate.TabIndex = 0;
            // 
            // dgvShowInfo
            // 
            this.dgvShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuId,
            this.StuName,
            this.Course,
            this.Score,
            this.ExamDate,
            this.Remark});
            this.dgvShowInfo.ContextMenuStrip = this.cmsRevise;
            this.dgvShowInfo.Location = new System.Drawing.Point(-4, 80);
            this.dgvShowInfo.Name = "dgvShowInfo";
            this.dgvShowInfo.RowTemplate.Height = 27;
            this.dgvShowInfo.Size = new System.Drawing.Size(917, 448);
            this.dgvShowInfo.TabIndex = 2;
            // 
            // StuId
            // 
            this.StuId.DataPropertyName = "StuId";
            this.StuId.HeaderText = "学号";
            this.StuId.Name = "StuId";
            this.StuId.Width = 150;
            // 
            // StuName
            // 
            this.StuName.DataPropertyName = "StuName";
            this.StuName.HeaderText = "姓名";
            this.StuName.Name = "StuName";
            this.StuName.Width = 150;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "课程";
            this.Course.Name = "Course";
            this.Course.Width = 150;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "成绩";
            this.Score.Name = "Score";
            this.Score.Width = 150;
            // 
            // ExamDate
            // 
            this.ExamDate.DataPropertyName = "ExamDate";
            this.ExamDate.HeaderText = "考试日期";
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Width = 150;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.Width = 150;
            // 
            // FrmShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 533);
            this.Controls.Add(this.dgvShowInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看考试信息";
            this.Load += new System.EventHandler(this.FrmShowInfo_Load);
            this.cmsRevise.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip cmsRevise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtExamDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiRevise;
        private System.Windows.Forms.DataGridView dgvShowInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}