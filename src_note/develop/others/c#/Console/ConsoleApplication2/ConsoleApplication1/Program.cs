using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //string connection_1 = "Data Source = .;Initial Catalog = QQuser;";//User ID = sa;
         
            string connection_1 = "Data Source=BDQN-1-PC43;Initial Catalog=QQuser;Integrated Security=True";
           SqlConnection Connection = new SqlConnection(connection_1);
            
            
            Connection.ConnectionString = connection_1;
            
            try
            {
                Connection.Open();
                Console.WriteLine("打开数据库成功！");

                string sql = "select * from QQuser";
                Connection.Open();
                //command.Connection = connection_1;
                //command.CommandText = sql;

                SqlCommand command = new SqlCommand(sql, Connection);


                //SqlCommand com = new SqlCommand(sql,connection_1);
                command.ExecuteNonQuery();
            

                 //command.SqlDataReader ExecuteReader();

            }

            catch(Exception ex)
            {
                Console.WriteLine("出现异常！" + ex.Message);
                //Console.ReadLine();
            }

            finally
            {
                Connection.Close();
                Console.WriteLine("关闭数据库成功！");
                Console.ReadLine();
            }



        }
    }
}
