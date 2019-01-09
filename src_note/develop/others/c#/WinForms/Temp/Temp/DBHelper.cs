using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{

    /// <summary>
    /// 数据库辅助类
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public const string STRCON = @"Data Source=.;Initial Catalog=MySchool;Integrated Security=True";

        /// <summary>
        /// 连接对象
        /// </summary>
        public SqlConnection Con
        {
            get { return new SqlConnection(STRCON); }
        }

        /// <summary>
        /// 返回命令对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlCommand GetCmd(string sql)
        {
            SqlConnection con = Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            return cmd;
        }


        /// <summary>
        /// 返回记录
        /// </summary>
        /// <returns></returns>
        public string GetTextTemp()
        {
            string sql = @"select * from Student",tempstr = "";
            using (Con)
            {
                try
                {
                    SqlDataReader dreader = GetCmd(sql).ExecuteReader();

                    while (dreader.Read())
                    {
                        tempstr += dreader["StudentNo"].ToString() + "\t"
                            + dreader["LoginPwd"].ToString() + "\t"
                            + dreader["StudentName"].ToString() + "\t"
                            + dreader["Sex"].ToString() + "\t"
                            + dreader["GradeId"].ToString() + "\t"
                            + dreader["Phone"].ToString() + "\t"
                            + dreader["Address"].ToString() + "\t"
                            + dreader["BornDate"].ToString() + "\t"
                            + dreader["Email"].ToString() + "\t"
                            + dreader["IdentityCard"].ToString() + "\n\n";
                    }
                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return tempstr;
        }

    }
}
