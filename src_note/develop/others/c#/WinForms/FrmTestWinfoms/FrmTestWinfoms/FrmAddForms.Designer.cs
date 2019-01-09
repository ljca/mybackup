namespace FrmTestWinfoms
{
    partial class FrmAddForms
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
            this.cboGerder = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboGerder
            // 
            this.cboGerder.FormattingEnabled = true;
            this.cboGerder.Location = new System.Drawing.Point(89, 208);
            this.cboGerder.Name = "cboGerder";
            this.cboGerder.Size = new System.Drawing.Size(253, 23);
            this.cboGerder.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(89, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(253, 25);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "工号";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(89, 87);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(253, 25);
            this.txtAge.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "年龄";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 25);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // FrmAddForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 323);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cboGerder);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmAddForms";
            this.Text = "员工信息维护";
            this.Load += new System.EventHandler(this.FrmAddForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboGerder;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}