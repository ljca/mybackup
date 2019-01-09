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

namespace SQLDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //先获取用户输入的用户名和密码
            string loginId = txtLoginId.Text;
            string loginPwd = txtLoginPwd.Text;

            //
            string sql = @"
select 
    * 
from 
    admin
where
    loginId=@loginId
    and
    loginPwd=@pwd
";  
            //替换占位符
            //sql = string.Format(sql, loginId, loginPwd);
            Console.WriteLine(sql);
            //数据库查询
            SqlConnection conn = new SqlConnection(
                "Data Source=.;Initial Catalog=MySchool;Integrated Security=True");
            //执行sql命令
            SqlCommand cmd = new SqlCommand(sql, conn);
            //动态替换参数的值 
            cmd.Parameters.AddWithValue("@loginId", loginId);
            cmd.Parameters.AddWithValue("@pwd", loginPwd);
            //查询结果有两:
            //首行首列(ExecuteScalar)
            //所有的结果(ExecuteReader)
            //CommandBehavior.CloseConnection:
            //关闭Reader的同时关闭连接

            conn.Open();//打开连接
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblUserName.Text = "登录成功" + dr["NickName"].ToString();
            }
            else
            {
                lblUserName.Text = "登录失败";
            }
            //关闭对象，释放资源
            dr.Close();
            conn.Close();
        }
    }
}
