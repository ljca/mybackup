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

namespace BoardScheduleManager
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            //禁止自动生成列
            dgvList.AutoGenerateColumns = false;
            SelectList("");// 查询所有那么就不给值
        }

         private void SelectList(string name)
        {
            //1.创建SqlDataAdapter对象
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT boardName, s.* FROM BoardroomInfo b INNER JOIN ScheduleInfo s ON b.id = s.boardroomId WHERE intendName like '%" + name + "%'",//查询的SQL语句
                @"Data Source=YLHHGG\MYSQL;Initial Catalog=BoardScheduleManger;Integrated Security=True"    //连接字符串
                );
            //2.创建DataTable或者DataSet
            DataTable dt = new DataTable();
            //3.填充数据
            da.Fill(dt);
            //4.绑定数据源
            dgvList.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectList(txtName.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
