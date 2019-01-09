namespace AirQuality
{
    partial class frmChaXun
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputNameSelect = new System.Windows.Forms.TextBox();
            this.btnChaZhao = new System.Windows.Forms.Button();
            this.btnGuanBi = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirQualityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXiuGai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShanChu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "录入人员：";
            // 
            // txtInputNameSelect
            // 
            this.txtInputNameSelect.Location = new System.Drawing.Point(83, 18);
            this.txtInputNameSelect.Name = "txtInputNameSelect";
            this.txtInputNameSelect.Size = new System.Drawing.Size(245, 21);
            this.txtInputNameSelect.TabIndex = 1;
            // 
            // btnChaZhao
            // 
            this.btnChaZhao.Location = new System.Drawing.Point(356, 16);
            this.btnChaZhao.Name = "btnChaZhao";
            this.btnChaZhao.Size = new System.Drawing.Size(75, 23);
            this.btnChaZhao.TabIndex = 2;
            this.btnChaZhao.Text = "查找";
            this.btnChaZhao.UseVisualStyleBackColor = true;
            this.btnChaZhao.Click += new System.EventHandler(this.btnChaZhao_Click);
            // 
            // btnGuanBi
            // 
            this.btnGuanBi.Location = new System.Drawing.Point(453, 16);
            this.btnGuanBi.Name = "btnGuanBi";
            this.btnGuanBi.Size = new System.Drawing.Size(75, 23);
            this.btnGuanBi.TabIndex = 2;
            this.btnGuanBi.Text = "关闭";
            this.btnGuanBi.UseVisualStyleBackColor = true;
            this.btnGuanBi.Click += new System.EventHandler(this.btnGuanBi_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.InputName,
            this.StartDate,
            this.EndDate,
            this.PM,
            this.Level,
            this.Notes,
            this.AirQualityID,
            this.StationID});
            this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvData.Location = new System.Drawing.Point(12, 55);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(810, 303);
            this.dgvData.TabIndex = 3;
            // 
            // StationName
            // 
            this.StationName.DataPropertyName = "StationName";
            this.StationName.HeaderText = "检测站";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // InputName
            // 
            this.InputName.DataPropertyName = "InputName";
            this.InputName.HeaderText = "录入人员";
            this.InputName.Name = "InputName";
            this.InputName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "开始检测时间";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "检测停止时间";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // PM
            // 
            this.PM.DataPropertyName = "PM";
            this.PM.HeaderText = "PM2.5指数";
            this.PM.Name = "PM";
            this.PM.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "空气质量等级";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "注意事项";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // AirQualityID
            // 
            this.AirQualityID.DataPropertyName = "AirQualityID";
            this.AirQualityID.HeaderText = "AirQualityID";
            this.AirQualityID.Name = "AirQualityID";
            this.AirQualityID.ReadOnly = true;
            this.AirQualityID.Visible = false;
            // 
            // StationID
            // 
            this.StationID.DataPropertyName = "StationID";
            this.StationID.HeaderText = "StationID";
            this.StationID.Name = "StationID";
            this.StationID.ReadOnly = true;
            this.StationID.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXiuGai,
            this.tsmiShanChu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmiXiuGai
            // 
            this.tsmiXiuGai.Name = "tsmiXiuGai";
            this.tsmiXiuGai.Size = new System.Drawing.Size(152, 22);
            this.tsmiXiuGai.Text = "修改";
            this.tsmiXiuGai.Click += new System.EventHandler(this.tsmiXiuGai_Click);
            // 
            // tsmiShanChu
            // 
            this.tsmiShanChu.Name = "tsmiShanChu";
            this.tsmiShanChu.Size = new System.Drawing.Size(152, 22);
            this.tsmiShanChu.Text = "删除";
            this.tsmiShanChu.Click += new System.EventHandler(this.tsmiShanChu_Click);
            // 
            // frmChaXun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 370);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnGuanBi);
            this.Controls.Add(this.btnChaZhao);
            this.Controls.Add(this.txtInputNameSelect);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChaXun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询监控结果";
            this.Load += new System.EventHandler(this.frmChaXun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputNameSelect;
        private System.Windows.Forms.Button btnChaZhao;
        private System.Windows.Forms.Button btnGuanBi;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirQualityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiXiuGai;
        private System.Windows.Forms.ToolStripMenuItem tsmiShanChu;
    }
}