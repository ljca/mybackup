using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Myschool
{
    class Program
    {
        static void Main(string[] args)
        {
            // string connString = "Data Source=.;Initial Catalog=QQ;User ID=sa;Password=123";
            // SqlConnection connection = new SqlConnection(connString);

            DBHelper db = new DBHelper();
            try
            {
                db.Open();
                Console.WriteLine("打开数据库成功");
                Console.WriteLine("请输入用户名：");
                string username = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                string password = Console.ReadLine();
                 string strSql =string.Format( "select count(1) from info "
                 + "where Logname='{0}' and Logpwd='{1}' ", username, password);
                //string strSql = string.Format("select Logname ,Logpwd  from info", username, password);
                SqlCommand comm = new SqlCommand(strSql, db.Connection);
                int userCount = (int)comm.ExecuteScalar();
                if (userCount == 1)
                {
                    Console.WriteLine("登录成功");
                }
                else
                {
                    Console.WriteLine("登录失败   用户名或密码错误");

                }


            }
            finally
            {
                db.Close();
                Console.WriteLine("关闭数据库成功");
            }
            Console.ReadLine();
        }


    }
}
