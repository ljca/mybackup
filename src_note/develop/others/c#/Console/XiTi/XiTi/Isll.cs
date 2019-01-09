using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace XiTi
{
    class Isll
    {

        string str = "Data Source=.;Initial Catalog=Live;Integrated Security=True";

        /// <summary>
        /// 
        /// </summary>
        public SqlDataReader ShowInfo()
        {
            SqlConnection cn = new SqlConnection(str);
            try
            {

                cn.Open();

                StringBuilder str_1 = new StringBuilder();
                str_1.AppendLine("select ")
                .AppendLine("  *")
                .AppendLine("  from")
                .AppendLine("  Carbon");
                SqlCommand cm = new SqlCommand(str_1.ToString(), cn);
                return cm.ExecuteReader();
   
            }
            catch (Exception)
            {
                Console.WriteLine("异常！********");
                return null;
            }
            finally
            {

                cn.Close();
                Console.WriteLine("退出！**********");
                Console.ReadLine();
            }
        }
    }
}
