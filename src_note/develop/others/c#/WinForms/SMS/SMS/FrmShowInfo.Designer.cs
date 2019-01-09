namespace SMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvShowDep = new System.Windows.Forms.ListView();
            this.StaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JoinDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工名字:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 25);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "(支持模糊查询)";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(563, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvShowDep
            // 
            this.lvShowDep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StaffName,
            this.DepName,
            this.staffLevel,
            this.JoinDate,
            this.State});
            this.lvShowDep.ForeColor = System.Drawing.Color.Blue;
            this.lvShowDep.FullRowSelect = true;
            this.lvShowDep.Location = new System.Drawing.Point(0, 67);
            this.lvShowDep.Name = "lvShowDep";
            this.lvShowDep.Size = new System.Drawing.Size(781, 399);
            this.lvShowDep.TabIndex = 3;
            this.lvShowDep.UseCompatibleStateImageBehavior = false;
            this.lvShowDep.View = System.Windows.Forms.View.Details;
            // 
            // StaffName
            // 
            this.StaffName.Text = "名字";
            this.StaffName.Width = 120;
            // 
            // DepName
            // 
            this.DepName.Text = "部门";
            this.DepName.Width = 120;
            // 
            // staffLevel
            // 
            this.staffLevel.Text = "级别";
            this.staffLevel.Width = 120;
            // 
            // JoinDate
            // 
            this.JoinDate.Text = "入职时间";
            this.JoinDate.Width = 120;
            // 
            // State
            // 
            this.State.Text = "状态";
            this.State.Width = 120;
            // 
            // FrmShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 478);
            this.Controls.Add(this.lvShowDep);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户查询";
            this.Load += new System.EventHandler(this.FrmShowInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvShowDep;
        private System.Windows.Forms.ColumnHeader StaffName;
        private System.Windows.Forms.ColumnHeader DepName;
        private System.Windows.Forms.ColumnHeader staffLevel;
        private System.Windows.Forms.ColumnHeader JoinDate;
        private System.Windows.Forms.ColumnHeader State;
    }
}