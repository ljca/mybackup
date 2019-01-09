using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test
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
        private const string connection_string =
            "Data Source=.;Initial Catalog=MySchool;Integrated Security=True";

        //数据库连接    字段
        private SqlConnection conn = new SqlConnection(
            connection_string);

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
        public void Open()
        {
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


    class Program
    {
        static void Main(string[] args)
        {
            DBHelper db = new DBHelper();
            string sql_1 = "select * from [Sexy]";
            db.GetDataReader(sql_1);
            Console.WriteLine("请输入你想执行的sql语句：");
            string sql = Console.ReadLine();
            db.Open();

            db.CreateCommand(sql);
            db.GetHashCode();

            string string_1 = db.ToString();
        }
    }
}
