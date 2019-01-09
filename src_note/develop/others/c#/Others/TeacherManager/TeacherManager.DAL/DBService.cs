using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace TeacherManager.DAL
{
    public class DBService
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private static string DB_CON_STR = ConfigurationManager.ConnectionStrings["DB_CON_STR"].ConnectionString;
        /// <summary>
        /// 当前数据库连接,用于当前数据库操作
        /// </summary>
        private SqlConnection _conn;
        /// <summary>
        /// 获取数据库连接对象
        /// </summary>
        /// <returns>数据库连接对象</returns>
        protected SqlConnection GetConnection()
        {
            _conn = new SqlConnection(DB_CON_STR); //创建连接
            return _conn;
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <param name="conn">连接对象</param>
        protected void Open(SqlConnection conn)
        {
            //判断连接状态并 打开连接
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        /// <summary>
        /// 打开当前操作的数据库连接
        /// </summary>
        protected void Open()
        {
            Open(_conn);
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <param name="conn">连接对象</param>
        protected void Close(SqlConnection conn)
        {
            conn.Close();
        }
        /// <summary>
        /// 关闭当前操作的数据库连接
        /// </summary>
        protected void Close()
        {
            Close(_conn);
        }
        /// <summary>
        /// 执行SQL语句并返回受影响的行数
        /// </summary>
        /// <param name="sql">执行的sql语句</param>
        /// <param name="ps">参数列表</param>
        /// <returns>受影响的行数</returns>
        public int ExecuteNonQuery(string sql, Dictionary<string, object> ps)
        {
            try
            {
                //执行sql返回结果
                return CreateCmd(sql, ps).ExecuteNonQuery();
            }
            catch (Exception e)
            {//捕获异常并 抛出
                throw e;
            }
            finally
            {
                //无论是否查询成功都关闭连接
                Close();
            }
        }

        /// <summary>
        /// 执行查询sql语句并返回数据读取对象
        /// </summary>
        /// <param name="sql">查询sql语句</param>
        /// <param name="ps">参数列表</param>
        /// <returns>数据读取对象</returns>
        public SqlDataReader ExecuteQuery(string sql, Dictionary<string, object> ps)
        {
            try
            {
                //执行sql返回结果
                return CreateCmd(sql, ps).ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {//捕获异常并 抛出
                throw e;
            }
        }

        /// <summary>
        /// 创建数据库执行对象并返回
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="ps">参数列表</param>
        /// <returns>command对象</returns>
        private SqlCommand CreateCmd(string sql, Dictionary<string, object> ps)
        {
            GetConnection(); //获取连接
            Open(); //打开连接
            SqlCommand cmd = new SqlCommand(sql, _conn); //创建command对象
            if (null != ps && ps.Count > 0) //设置参数
            {//判断是否有参数
                foreach (KeyValuePair<string, object> item in ps)
                {//循环设置sql参数
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            //返回
            return cmd;
        }
    }
}
