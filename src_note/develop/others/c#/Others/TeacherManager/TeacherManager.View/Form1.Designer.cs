namespace TeacherManager.View
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.dgvTeacherList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherList
            // 
            this.dgvTeacherList.AllowUserToAddRows = false;
            this.dgvTeacherList.AllowUserToDeleteRows = false;
            this.dgvTeacherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherName,
            this.Tid,
            this.Age,
            this.TeachGrade,
            this.TeachYear,
            this.OPS});
            this.dgvTeacherList.Location = new System.Drawing.Point(12, 12);
            this.dgvTeacherList.MultiSelect = false;
            this.dgvTeacherList.Name = "dgvTeacherList";
            this.dgvTeacherList.ReadOnly = true;
            this.dgvTeacherList.RowTemplate.Height = 23;
            this.dgvTeacherList.Size = new System.Drawing.Size(646, 243);
            this.dgvTeacherList.TabIndex = 0;
            this.dgvTeacherList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherList_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(554, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除选中数据";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "名字";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // Tid
            // 
            this.Tid.DataPropertyName = "Tid";
            this.Tid.HeaderText = "tid";
            this.Tid.Name = "Tid";
            this.Tid.ReadOnly = true;
            this.Tid.Visible = false;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // TeachGrade
            // 
            this.TeachGrade.HeaderText = "年级";
            this.TeachGrade.Name = "TeachGrade";
            this.TeachGrade.ReadOnly = true;
            // 
            // TeachYear
            // 
            this.TeachYear.DataPropertyName = "TeachYear";
            this.TeachYear.HeaderText = "教龄";
            this.TeachYear.Name = "TeachYear";
            this.TeachYear.ReadOnly = true;
            // 
            // OPS
            // 
            this.OPS.HeaderText = "操作";
            this.OPS.Name = "OPS";
            this.OPS.ReadOnly = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 294);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvTeacherList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "教师管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacherList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeachGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeachYear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OPS;
    }
}

