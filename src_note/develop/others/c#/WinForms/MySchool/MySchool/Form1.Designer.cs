namespace MySchool
{
    partial class Seach_Forms
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
            this.btn_Seach = new System.Windows.Forms.Button();
            this.cbo_Seach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Seach
            // 
            this.btn_Seach.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Seach.Location = new System.Drawing.Point(284, 28);
            this.btn_Seach.Name = "btn_Seach";
            this.btn_Seach.Size = new System.Drawing.Size(124, 36);
            this.btn_Seach.TabIndex = 0;
            this.btn_Seach.Text = "搜索";
            this.btn_Seach.UseVisualStyleBackColor = true;
            this.btn_Seach.Click += new System.EventHandler(this.btn_Seach_Click);
            // 
            // cbo_Seach
            // 
            this.cbo_Seach.FormattingEnabled = true;
            this.cbo_Seach.Location = new System.Drawing.Point(87, 33);
            this.cbo_Seach.Name = "cbo_Seach";
            this.cbo_Seach.Size = new System.Drawing.Size(177, 23);
            this.cbo_Seach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "年级:";
            // 
            // dgv_Student
            // 
            this.dgv_Student.AllowUserToDeleteRows = false;
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Location = new System.Drawing.Point(12, 74);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.ReadOnly = true;
            this.dgv_Student.RowTemplate.Height = 27;
            this.dgv_Student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Student.Size = new System.Drawing.Size(883, 494);
            this.dgv_Student.TabIndex = 3;
            // 
            // Seach_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 593);
            this.Controls.Add(this.dgv_Student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Seach);
            this.Controls.Add(this.btn_Seach);
            this.MaximizeBox = false;
            this.Name = "Seach_Forms";
            this.Text = "查询";
            this.Load += new System.EventHandler(this.Seach_Forms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Seach;
        private System.Windows.Forms.ComboBox cbo_Seach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Student;
    }
}

