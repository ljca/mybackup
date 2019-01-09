using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExamSys
{
    /// <summary>
    /// 用于ADO.NET的辅助类
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// 用于ADO.NET执行的sql
        /// </summary>
        public static string sql = "";

        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string strcon = @"Data Source=YLHHGG\MYSQL;Initial Catalog=ExamSys;Integrated Security=True";

        /// <summary>
        /// 数据适配器对象！
        /// </summary>
        public static SqlDataAdapter da = null;

        /// <summary>
        /// cmd对象！
        /// </summary>
        public static SqlCommand cmd = null;

        /// <summary>
        /// 连接对象！
        /// </summary>
        public static SqlConnection cn = null;

        /// <summary>
        /// 数据集对象！
        /// </summary>
        public static DataSet ds = null;
    }
}
