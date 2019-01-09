using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strcon = "Data Source=.;Initial Catalog=Admin;Integrated Security=True";
           s: Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                string sql = "select * from [admins] where Name = '" + name + "' and Pwd='" + password + "' ";
                con.Open();

                SqlCommand comd = new SqlCommand(sql,con);
                object xy = (int)comd.ExecuteScalar();
                if ((int)xy == 1)
                {
                    Console.WriteLine("登录成功！");
                }
                else
                {
                    goto s;
                }
                   
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.Read();
            }
            finally
            {
                con.Close();
 
            }




        }
    }
}
