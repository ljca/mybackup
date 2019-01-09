using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrmShowInfo
{
    public class DBHelper
    {
        /// <summary>
        /// 连接字符串！
        /// </summary>

        public static string constr = @"Data Source=YLHHGG\MYSQL;Initial Catalog=MyKTV;Integrated Security=True";

        /// <summary>
        /// sql语句
        /// </summary>
        public static string sql = "";

        /// <summary>
        /// 连接对象
        /// </summary>
        private static SqlConnection cn = null;

        public static SqlConnection Cn
        {
            get
            {
                if (cn == null)
                {
                    cn = new SqlConnection(constr);
                }
                return cn;
            }
            set { DBHelper.cn = value; }
        }

        /// <summary>
        ///sql语句执行对象
        /// </summary>
        public static SqlCommand cmd = null;

        /// <summary>
        /// 读取对象
        /// </summary>
        public static SqlDataReader dr = null;

        public static void CheckCn()
        {
            if (Cn.State == System.Data.ConnectionState.Closed
                || Cn.State == System.Data.ConnectionState.Broken)
            {
                cn.Open();
            }
            else
            {
                Cn.Close();
            }
        }

        /// <summary>
        ///或取读取对象
        /// </summary>
        /// <param name="sql"></param>
        public static SqlDataReader GetReader(string sql)
        {
            cmd = new SqlCommand(sql, Cn);
            dr = cmd.ExecuteReader();
            return dr;
        }

    }
}
