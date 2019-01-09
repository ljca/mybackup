namespace ExamSys
{
    partial class FrmRevise
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblStuId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExamDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnCanCel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号：";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(243, 6);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(215, 25);
            this.txtStuName.TabIndex = 2;
            // 
            // lblStuId
            // 
            this.lblStuId.AutoSize = true;
            this.lblStuId.Location = new System.Drawing.Point(82, 9);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(55, 15);
            this.lblStuId.TabIndex = 1;
            this.lblStuId.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "课程：";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(550, 6);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(215, 25);
            this.txtCourse.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "考试时间：";
            // 
            // txtExamDate
            // 
            this.txtExamDate.Location = new System.Drawing.Point(151, 69);
            this.txtExamDate.Name = "txtExamDate";
            this.txtExamDate.Size = new System.Drawing.Size(215, 25);
            this.txtExamDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "成绩：";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(550, 69);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(215, 25);
            this.txtScore.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "备注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(112, 162);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(653, 103);
            this.txtRemark.TabIndex = 2;
            // 
            // btnCanCel
            // 
            this.btnCanCel.Location = new System.Drawing.Point(291, 289);
            this.btnCanCel.Name = "btnCanCel";
            this.btnCanCel.Size = new System.Drawing.Size(93, 32);
            this.btnCanCel.TabIndex = 0;
            this.btnCanCel.Text = "取消";
            this.btnCanCel.UseVisualStyleBackColor = true;
            this.btnCanCel.Click += new System.EventHandler(this.btnCanCel_Click);
            // 
            // FrmRevise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 342);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtExamDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStuId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCanCel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRevise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改学生信息";
            this.Load += new System.EventHandler(this.FrmRevise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExamDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnCanCel;
    }
}