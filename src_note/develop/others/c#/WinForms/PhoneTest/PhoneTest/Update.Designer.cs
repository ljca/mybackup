namespace PhoneTest
{
    partial class Update_Form
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
            this.txt_Sale_Nuber = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSava = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbSaleId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Sale_Nuber
            // 
            this.txt_Sale_Nuber.Location = new System.Drawing.Point(214, 21);
            this.txt_Sale_Nuber.Name = "txt_Sale_Nuber";
            this.txt_Sale_Nuber.Size = new System.Drawing.Size(100, 25);
            this.txt_Sale_Nuber.TabIndex = 0;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(456, 21);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 25);
            this.txt_Price.TabIndex = 1;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(104, 121);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(473, 65);
            this.txt_Remark.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "销售编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "销售数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "备注:";
            // 
            // btnSava
            // 
            this.btnSava.Location = new System.Drawing.Point(214, 264);
            this.btnSava.Name = "btnSava";
            this.btnSava.Size = new System.Drawing.Size(83, 23);
            this.btnSava.TabIndex = 8;
            this.btnSava.Text = "保存";
            this.btnSava.UseVisualStyleBackColor = true;
            this.btnSava.Click += new System.EventHandler(this.btnSava_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbSaleId
            // 
            this.lbSaleId.AutoSize = true;
            this.lbSaleId.Location = new System.Drawing.Point(91, 24);
            this.lbSaleId.Name = "lbSaleId";
            this.lbSaleId.Size = new System.Drawing.Size(15, 15);
            this.lbSaleId.TabIndex = 10;
            this.lbSaleId.Text = "2";
            // 
            // Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 304);
            this.Controls.Add(this.lbSaleId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Sale_Nuber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Update_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改窗体";
            this.Load += new System.EventHandler(this.Update_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Sale_Nuber;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSava;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbSaleId;
    }
}