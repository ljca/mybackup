using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Common.DBTool
{
    /// <summary>
    /// 提供操作数据的工具类
    /// 1.连接数据库
    /// 2.打开数据连接
    /// 3.关闭数据连接
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private const string CONNECTION_STRING =
            "Data Source=.;Initial Catalog=AccpDemo;Integrated Security=True";
        
        //数据库连接    字段
        private SqlConnection conn = new SqlConnection(
            CONNECTION_STRING);

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        public SqlConnection Connection
        {
            get { return conn; }
        }


        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void Open() {
            //判断是否已经打开，如果已经打开，不执行打开操作
            if (conn.State == ConnectionState.Closed || 
                conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


        /// <summary>
        /// 执行SQL命令获得DataReader对象，读取数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>DataReader对象</returns>
        public SqlDataReader GetDataReader(string sql)
        {
            SqlCommand cmd = CreateCommand(sql);
            this.Open();//调用本类的Open方法打开数据库连接
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;//SqlDataReader对象
        }

        /// <summary>
        /// 创建command对象用于执行SQL命令
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>Command对象</returns>
        public SqlCommand CreateCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand();//创建Command用于获取DataReader
            cmd.Connection = conn;//指定连接
            cmd.CommandText = sql;//赋值sql语句
            
            return cmd;
        }
    }
}
