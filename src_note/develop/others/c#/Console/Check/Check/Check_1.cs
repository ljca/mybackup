using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Check
{
    /// <summary>
    /// 
    /// </summary>
    class Check_1
    {
        private const string strCon = "Data Source=.;Initial Catalog=QQManager;Integrated Security=True";
        /// <summary>
        /// 
        /// </summary>
        public void CheckUserInfo(string userName,string password)
        {
            SqlConnection cn = new SqlConnection(strCon);
            try
            {
                string sql = "select count(*) from LogInfo"; // where LogInName ='QQ'" + userName + "and LogInPass ='12345'" + password + "";
                cn.Open();
                SqlCommand cm = new SqlCommand(sql,cn);
                string sql_2 = "select count(*) from QQuserInfo as C";
                   // + "inner join QQx as D on C.QQId = D.QQId"; 
                SqlCommand cs = new SqlCommand(sql_2,cn);
                int ia = (int)cs.ExecuteScalar();
                int it = (int)cm.ExecuteScalar();   


                if(it == 0 || ia == 0)
                {
                    //return false;
                    Console.WriteLine("输入无效！");
                }
                else 
                {
                    //return true;
                    Console.WriteLine("共查到记录:" + ia);
                    Console.WriteLine("共查到记录:" + it);
                    Console.WriteLine("登陆成功！");
                    Console.ReadLine();
                }
                
            }
            catch(Exception ex) 
            {

                Console.WriteLine("异常！" + ex.Message);
                Console.ReadLine();
            }
            finally 
            {
                cn.Close();
                
            }
 
        }

    }
}
