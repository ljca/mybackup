using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace cssxs
{
    class SQL
    {
        string str = "Data Source=.;Initial Catalog=Live;Integrated Security=True";
        public void SqlServer()
        {

            SqlConnection cn = new SqlConnection(str);
            try
            {
                cn.Open();
                StringBuilder st = new StringBuilder();
                st.AppendLine("select ")
                    .AppendLine("* ")
                    .AppendLine("from ")
                    .AppendLine("[Live]");
                SqlCommand cm = new SqlCommand(st.ToString(), cn);
                
            }
            catch (Exception)
            {
                Console.WriteLine("访问数据库失败！");
                Console.WriteLine("异常！退出！");
            }
            finally
            {
                cn.Close();
            }
            
        }

    }
}
