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
    public partial class Update_Form : Form
    {
        public Update_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 数据集对象
        /// </summary>
        private DataSet ds;
 
        /// <summary>
        /// 用于读取数据库的对象
        /// </summary>
        private SqlDataAdapter dreader;

       /// <summary>
       /// 用于连接数据库的连接字符串
       /// </summary>
        private const string STR = "Data Source=.;Initial Catalog=PhoneCardSys;Integrated Security=True";



        //定义在窗体间传递数据的字段
        public string SaleID;
        public string SaleNuber;
        public string Remark;
        public string Price;

        /// <summary>
        ///窗体启动即载入数据
        ///在PhoneCardInfo窗体给修改窗体的字段赋值
        ///在修改窗体将字段赋给控件的Text属性，即使未初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Form_Load(object sender, EventArgs e)
        {

            this.txt_Sale_Nuber.Text = SaleNuber;
            this.txt_Price.Text = Price;
            this.txt_Remark.Text = Remark;
            this.lbSaleId.Text = SaleID;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSava_Click(object sender, EventArgs e)
        {


            this.ds = new DataSet();
            string sql = "update [PhoneCardSale] set Remark = '20元' where 1 = 1 and SaleId = 3";
            SqlConnection cn = new SqlConnection(STR);
            cn.Open();
            SqlCommand cm = new SqlCommand(sql,cn);
            
            this.dreader = new SqlDataAdapter(sql, STR);

            DialogResult result = MessageBox.Show("确认要修改吗?", "修改提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
               
                try
                {
                    SqlCommandBuilder cmmand = new SqlCommandBuilder(dreader);
                    dreader.Update(ds, "PhoneCardSale");

                    if ((int)(cm.ExecuteNonQuery()) == 1)
                    {
                        MessageBox.Show("修改成功！");
                    }
                    else
                    {

                        MessageBox.Show("修改失败!");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("请检查数据库连接！");
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }
          
        }
    }
}
