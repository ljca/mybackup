namespace SuperMark
{
    partial class FrmSuperMannger
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.rbPt = new System.Windows.Forms.RadioButton();
            this.rbDiamond = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvSuper = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsDel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuper)).BeginInit();
            this.cmsDel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "超市会员管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "状态:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "账户积分:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(79, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(158, 25);
            this.txtId.TabIndex = 5;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(364, 210);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(158, 25);
            this.txtScore.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(364, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 25);
            this.txtPassword.TabIndex = 7;
            // 
            // cboStates
            // 
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(93, 213);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(158, 23);
            this.cboStates.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGold);
            this.groupBox1.Controls.Add(this.rbPt);
            this.groupBox1.Controls.Add(this.rbDiamond);
            this.groupBox1.Location = new System.Drawing.Point(35, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "卡别:";
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Location = new System.Drawing.Point(6, 34);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(58, 19);
            this.rbGold.TabIndex = 10;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "金卡";
            this.rbGold.UseVisualStyleBackColor = true;
            // 
            // rbPt
            // 
            this.rbPt.AutoSize = true;
            this.rbPt.Location = new System.Drawing.Point(136, 34);
            this.rbPt.Name = "rbPt";
            this.rbPt.Size = new System.Drawing.Size(73, 19);
            this.rbPt.TabIndex = 11;
            this.rbPt.TabStop = true;
            this.rbPt.Text = "铂金卡";
            this.rbPt.UseVisualStyleBackColor = true;
            // 
            // rbDiamond
            // 
            this.rbDiamond.AutoSize = true;
            this.rbDiamond.Location = new System.Drawing.Point(286, 34);
            this.rbDiamond.Name = "rbDiamond";
            this.rbDiamond.Size = new System.Drawing.Size(73, 19);
            this.rbDiamond.TabIndex = 12;
            this.rbDiamond.TabStop = true;
            this.rbDiamond.Text = "钻石卡";
            this.rbDiamond.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(687, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(687, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvSuper
            // 
            this.dgvSuper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerType,
            this.Score,
            this.StatesName});
            this.dgvSuper.ContextMenuStrip = this.cmsDel;
            this.dgvSuper.Location = new System.Drawing.Point(-8, 259);
            this.dgvSuper.Name = "dgvSuper";
            this.dgvSuper.RowTemplate.Height = 27;
            this.dgvSuper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuper.Size = new System.Drawing.Size(916, 278);
            this.dgvSuper.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "CustomerId";
            this.Id.HeaderText = "账号名";
            this.Id.Name = "Id";
            // 
            // CustomerType
            // 
            this.CustomerType.DataPropertyName = "CustomerType";
            this.CustomerType.HeaderText = "卡别";
            this.CustomerType.Name = "CustomerType";
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "积分";
            this.Score.Name = "Score";
            // 
            // StatesName
            // 
            this.StatesName.DataPropertyName = "SatesName";
            this.StatesName.HeaderText = "账户状态";
            this.StatesName.Name = "StatesName";
            // 
            // cmsDel
            // 
            this.cmsDel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDel});
            this.cmsDel.Name = "cmsDel";
            this.cmsDel.Size = new System.Drawing.Size(109, 28);
            // 
            // tsDel
            // 
            this.tsDel.Name = "tsDel";
            this.tsDel.Size = new System.Drawing.Size(108, 24);
            this.tsDel.Text = "删除";
            this.tsDel.Click += new System.EventHandler(this.tsDel_Click);
            // 
            // FrmSuperMannger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 540);
            this.Controls.Add(this.dgvSuper);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmSuperMannger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市会员管理系统";
            this.Load += new System.EventHandler(this.FrmSuperMannger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuper)).EndInit();
            this.cmsDel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.RadioButton rbPt;
        private System.Windows.Forms.RadioButton rbDiamond;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvSuper;
        private System.Windows.Forms.ContextMenuStrip cmsDel;
        private System.Windows.Forms.ToolStripMenuItem tsDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatesName;
    }
}

