namespace SMS
{
    partial class FrmAdd
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
            this.cboDepName = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStafName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工名字：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 25);
            this.txtName.TabIndex = 2;
            // 
            // cboDepName
            // 
            this.cboDepName.FormattingEnabled = true;
            this.cboDepName.Location = new System.Drawing.Point(100, 68);
            this.cboDepName.Name = "cboDepName";
            this.cboDepName.Size = new System.Drawing.Size(295, 23);
            this.cboDepName.TabIndex = 3;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(100, 206);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(295, 25);
            this.dtpTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工级别：";
            // 
            // txtStafName
            // 
            this.txtStafName.Location = new System.Drawing.Point(100, 128);
            this.txtStafName.Name = "txtStafName";
            this.txtStafName.Size = new System.Drawing.Size(295, 25);
            this.txtStafName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "所属部门：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "员工状态：";
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(100, 268);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(295, 23);
            this.cboState.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "入职时间：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(301, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 447);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.cboDepName);
            this.Controls.Add(this.txtStafName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加新员工";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboDepName;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStafName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}