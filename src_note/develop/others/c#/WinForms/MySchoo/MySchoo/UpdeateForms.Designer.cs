namespace MySchoo
{
    partial class UpdeateForms
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Seach = new System.Windows.Forms.Button();
            this.LvShow = new System.Windows.Forms.ListView();
            this.Student_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Sexy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Homo_Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 25);
            this.textBox1.TabIndex = 0;
            // 
            // btn_Seach
            // 
            this.btn_Seach.Location = new System.Drawing.Point(218, 51);
            this.btn_Seach.Name = "btn_Seach";
            this.btn_Seach.Size = new System.Drawing.Size(75, 23);
            this.btn_Seach.TabIndex = 1;
            this.btn_Seach.Text = "查找";
            this.btn_Seach.UseVisualStyleBackColor = true;
            this.btn_Seach.Click += new System.EventHandler(this.btn_Seach_Click);
            // 
            // LvShow
            // 
            this.LvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Student_Name,
            this.Student_Sexy,
            this.Student_Age,
            this.Homo_Adress,
            this.Student_Mail});
            this.LvShow.FullRowSelect = true;
            this.LvShow.GridLines = true;
            this.LvShow.Location = new System.Drawing.Point(32, 118);
            this.LvShow.Name = "LvShow";
            this.LvShow.Size = new System.Drawing.Size(706, 363);
            this.LvShow.TabIndex = 2;
            this.LvShow.UseCompatibleStateImageBehavior = false;
            this.LvShow.View = System.Windows.Forms.View.Details;
            // 
            // Student_Name
            // 
            this.Student_Name.Text = "姓名";
            this.Student_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Student_Name.Width = 86;
            // 
            // Student_Sexy
            // 
            this.Student_Sexy.Text = "性别";
            this.Student_Sexy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Student_Sexy.Width = 57;
            // 
            // Student_Age
            // 
            this.Student_Age.Text = "年龄";
            this.Student_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Student_Age.Width = 58;
            // 
            // Homo_Adress
            // 
            this.Homo_Adress.Text = "家庭住址";
            this.Homo_Adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Homo_Adress.Width = 234;
            // 
            // Student_Mail
            // 
            this.Student_Mail.Text = "邮箱";
            this.Student_Mail.Width = 366;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "支持模糊查询";
            // 
            // UpdeateForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LvShow);
            this.Controls.Add(this.btn_Seach);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdeateForms";
            this.Text = "查询更新数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Seach;
        private System.Windows.Forms.ListView LvShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Student_Name;
        private System.Windows.Forms.ColumnHeader Student_Sexy;
        private System.Windows.Forms.ColumnHeader Student_Age;
        private System.Windows.Forms.ColumnHeader Homo_Adress;
        private System.Windows.Forms.ColumnHeader Student_Mail;
    }
}