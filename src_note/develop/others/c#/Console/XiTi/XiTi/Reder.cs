using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace XiTi
{
    /// <summary>
    /// 
    /// </summary>
  class Reder
    {
        Info fo = new Info();
        Isll zx = new Isll();
        

        /// <summary>
        /// 
        /// </summary>
        public void sx()
        {
           
            try
            {
                SqlDataReader reader = zx.ShowInfo();
                if (reader == null)
                {
                    Console.WriteLine();
                    return;
                }
                Console.WriteLine("编号\t名称\t单位\t消耗量\t类别名称");
                StringBuilder str = new StringBuilder();
                while (reader.Read())
                {
                    /*
                    str_1.AppendFormat("{0}",reader["CBName"]);
                    Console.WriteLine(str_1);
                    str_1.Length = 0;
                    */

                    str.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}", reader["CBID"], reader["CBName"], reader["CBUnit"], reader["CBValue"], reader["CBValue"]);

                    Console.WriteLine(str);
                    str.Length = 0;

                    //string xs = reader[""].ToString();


                }
                Console.WriteLine("执行成功！********");
                reader.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ss()
        {

        }


    }
}
