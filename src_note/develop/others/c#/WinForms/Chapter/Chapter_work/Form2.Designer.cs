namespace Chapter_work
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(99, 10);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtDescript
            // 
            this.txtDescript.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDescript.Location = new System.Drawing.Point(99, 58);
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(171, 88);
            this.txtDescript.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "评价";
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtScore.Location = new System.Drawing.Point(99, 176);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 34);
            this.txtScore.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "分数";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(68, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}