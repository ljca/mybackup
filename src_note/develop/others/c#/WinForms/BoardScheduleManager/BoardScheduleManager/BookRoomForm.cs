using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardScheduleManager
{
    public partial class BookRoomForm : Form
    {
        public BookRoomForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbRoom.SelectedIndex = 0;
            txtEnterName.Text = "";
            txtHours.Text = "";
            txtIntendedName.Text = "";
            txtReason.Text = "";
            txtStartTime.Text = "";
        }

        private void BookRoomForm_Load(object sender, EventArgs e)
        {
            //1.创建SqlDataAdapter对象
            #region SqlDataAdapter da = new SqlDataAdapter()
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT * FROM BoardroomInfo",//查询的SQL语句
                @"Data Source=YLHHGG\MYSQL;Initial Catalog=BoardScheduleManger;Integrated Security=True"//"Data Source=.;Initial Catalog=BoardScheduleManager;Integrated Security=True"    //连接字符串
                );
            #endregion
            //2.创建DataTable或者DataSet
            DataTable dt = new DataTable();
            //3.填充数据
            da.Fill(dt);
            //4.绑定数据源
            cbRoom.DataSource = dt;
            cbRoom.DisplayMember = "boardName";
            cbRoom.ValueMember = "id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtEnterName.Text == ""||
                txtHours.Text == "" ||
                txtIntendedName.Text == "" ||
                txtReason.Text == "" ||
                txtStartTime.Text == "")
            {
                MessageBox.Show("录入信息不完整");
                return;
            }



            //1.创建连接对象及即开连接
            SqlConnection conn = new SqlConnection(@"Data Source=YLHHGG\MYSQL;Initial Catalog=BoardScheduleManger;Integrated Security=True");//Data Source=.;Initial Catalog=BoardScheduleManager;Integrated Security=True");
            try
            {
                string sql = @"insert into
    ScheduleInfo
        ([boardroomId]
           ,[intendName]
           ,[startTime]
           ,[duration]
           ,[enteringName]
           ,[reason])
    VALUES
           (" + cbRoom.SelectedValue + ",'" + txtIntendedName.Text + "','" + txtStartTime.Text
             + "','" + txtHours.Text + "','" + txtEnterName.Text + "','" + txtReason.Text + "')";
                conn.Open();
                //2.创建Command对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                //3.调用ExecuteNonQuery方法,返回受影响的行数(int)
                int num = cmd.ExecuteNonQuery();
                //4.判断受影响的行数
                if (num == 1)
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加异常了"+ex.Message);
            }
            finally
            {
                //5.关闭连接
                conn.Close();
            }

        }
    }
}
