using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmWeiHu : Form
    {
        public frmWeiHu()
        {
            InitializeComponent();
        }
        //窗体加载
        private void frmWeiHu_Load(object sender, EventArgs e)
        {

        }
        //删除
        private void tsbtnShanChu_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定删除吗？", 
                                    "提示", 
                                    MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //进行删除操作

            }

        }
        //退出
        private void tsbtnTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //从dgv中读取数据，显示到界面下半部分
            //this.dgvData.SelectedRows[0].Cells["列名"].Value;
            this.txtNumber.Text =  this.dgvData.SelectedRows[0].Cells["Number"].Value.ToString();
            this.txtBeds.Text = this.dgvData.SelectedRows[0].Cells["Beds"].Value.ToString();
            this.txtPrice.Text = this.dgvData.SelectedRows[0].Cells["Price"].Value.ToString();
            this.txtRemark.Text = this.dgvData.SelectedRows[0].Cells["Remark"].Value.ToString();
            //方式二
            int rowindex = this.dgvData.CurrentRow.Index;//当前行序号
                rowindex = this.dgvData.SelectedRows[0].Index;//被选中的第一行序号 
            this.txtNumber.Text = this.dgvData["Number", rowindex].Value.ToString();
            this.txtNumber.Text = this.dgvData[0, rowindex].Value.ToString();
        }
    }
}
