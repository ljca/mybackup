namespace BoardScheduleManager
{
    partial class SelectForm
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intendedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(384, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(116, 31);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "预定人姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(141, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 31);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.room,
            this.intendedName,
            this.startTime,
            this.hours,
            this.enterName,
            this.reason});
            this.dgvList.Location = new System.Drawing.Point(12, 65);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(743, 245);
            this.dgvList.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "预定编号";
            this.id.Name = "id";
            // 
            // room
            // 
            this.room.DataPropertyName = "boardName";
            this.room.HeaderText = "预定会议室";
            this.room.Name = "room";
            // 
            // intendedName
            // 
            this.intendedName.DataPropertyName = "intendedName";
            this.intendedName.HeaderText = "预定人姓名";
            this.intendedName.Name = "intendedName";
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "startTime";
            this.startTime.HeaderText = "开始时间";
            this.startTime.Name = "startTime";
            // 
            // hours
            // 
            this.hours.DataPropertyName = "duration";
            this.hours.HeaderText = "预定时长";
            this.hours.Name = "hours";
            // 
            // enterName
            // 
            this.enterName.DataPropertyName = "enteringName";
            this.enterName.HeaderText = "录入人姓名";
            this.enterName.Name = "enterName";
            // 
            // reason
            // 
            this.reason.DataPropertyName = "reason";
            this.reason.HeaderText = "预定原因";
            this.reason.Name = "reason";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(638, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 364);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Name = "SelectForm";
            this.Text = "查询预定情况";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn intendedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
    }
}