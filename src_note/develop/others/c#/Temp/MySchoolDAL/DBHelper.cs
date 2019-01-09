using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolDAL
{
    public class DBHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private static readonly string DB_CONNECTION_STRING =
            ConfigurationManager.ConnectionStrings["MySchool_DB"].ToString();

        //数据库连接
        protected SqlConnection Conn {
            get
            {
               return new SqlConnection(DB_CONNECTION_STRING);
            }
        }

        protected DataSet GetDataSetBySQL(string sql)
        {
            //创建dataadapter对象
            SqlDataAdapter da = new SqlDataAdapter(sql, Conn);
            //c创建数据集
            DataSet ds = new DataSet();
            //填充数据集
            da.Fill(ds, "datalist");
            return ds;
        }

        protected object ExecuteScalar(string sql)
        {
            ///保存使用的同一连接对象
            SqlConnection conn = Conn;
            using (conn)
            {
                conn.Open();//打开连接
                SqlCommand cmd = new SqlCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
        }

        /// <summary>
        /// 根据sql语句获取查询的数据结果读取器
        /// </summary>
        /// <param name="sql">查询的sql语句</param>
        /// <returns></returns>
        public SqlDataReader ExecuteReader(string sql)
        {
            ///保存使用的同一连接对象
            SqlConnection conn = Conn;
            conn.Open();//打开连接
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

    }
}
