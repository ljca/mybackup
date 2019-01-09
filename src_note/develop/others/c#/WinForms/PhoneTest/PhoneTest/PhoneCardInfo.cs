using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhoneTest
{
    public partial class PhoneCardInfo : Form
    {
        public PhoneCardInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 数据集对象
        /// </summary>
        private DataSet ds;

        /// <summary>
        /// 数据适配器对象
        /// </summary>
        private SqlDataAdapter dreader;




        /// <summary>
        /// 修改学生信息
        /// 窗体载入时将选中行的值传递到修改窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctmUp_Click(object sender, EventArgs e)
        {
           
            Update_Form up = new Update_Form();
            //up.MdiParent = this;
            
            //将DataGridView控件选中行的某些列值赋值给修改窗体的字段
            //在PhoneCardInfo窗体给修改窗体的字段赋值
            //在显示修改窗体之前，将DataGridView控件选中行的某些列的值传递给修改窗体的字段
            //以使修改窗体的某些控件能显示数据
            up.SaleID = this.dgvSaleInfo.SelectedRows[0].Cells[0].Value.ToString();
            up.SaleNuber = this.dgvSaleInfo.SelectedRows[0].Cells[2].Value.ToString();
            up.Remark = this.dgvSaleInfo.SelectedRows[0].Cells[5].Value.ToString();
            up.Price = this.dgvSaleInfo.SelectedRows[0].Cells[4].Value.ToString();

            /*
            up.SaleID = this.dgvSaleInfo.SelectedRows[0].Cells["SaleId"].Value.ToString();
            up.SaleNuber = this.dgvSaleInfo.SelectedRows[0].Cells["SaleCount"].Value.ToString();
            up.Remark = this.dgvSaleInfo.SelectedRows[0].Cells["Remark"].Value.ToString();
            up.Price = this.dgvSaleInfo.SelectedRows[0].Cells["SalePrice"].Value.ToString();
            */

            //以模式化窗体显示修改窗体
            up.ShowDialog();
        }

        /// <summary>
        /// 显示电话卡销售信息
        /// 绑定数据列
        /// 窗体启动即查询数据表[PhoneCardInfo]中的数据并填充数据到DataGridView控件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowInfo_Load(object sender, EventArgs e)
        {
            string sql = "select * from [PhoneCardSale]";
            try
            {
                this.ds = new DataSet();
                this.dreader = new SqlDataAdapter(sql, "Data Source=.;Initial Catalog=PhoneCardSys;Integrated Security=True");
                
               //如果DataGridView控件的数据表不为空，则先清空数据再填充数据表
                if (ds.Tables["PhoneCardSale"] != null)
                {
                    ds.Tables["PhoneCardSale"].Clear();
                }

                dreader.Fill(ds, "PhoneCardSale");

                //不允许DataGridView控件自动生成列
                this.dgvSaleInfo.AutoGenerateColumns = false;

                //在填充数据之后绑定数据源
                this.dgvSaleInfo.DataSource = ds.Tables["PhoneCardSale"];

            }
            catch(Exception ex)
            {
                
                MessageBox.Show("发生错误！");
                throw ex;
            }
            finally
            {
                //MessageBox.Show("运行结束！");
            }
        }


    }
}
