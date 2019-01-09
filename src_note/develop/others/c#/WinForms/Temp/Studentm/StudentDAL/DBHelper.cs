using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace StudentDAL
{
    public class DBHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private const string CONSTR = @"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True";

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        public SqlConnection Con
        {
            get { return new SqlConnection(CONSTR); }
        }

        /// <summary>
        /// 打开连接
        /// </summary>
        public bool OpenCon()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 关闭链接
        /// </summary>
        public void CloseCon()
        {
            if (Con.State == ConnectionState.Broken
                || Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        /// <summary>
        /// 命令集对象
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>命令集对象</returns>
        public SqlCommand GetCmd(string sql)
        {
            SqlConnection Con = this.Con;
            //OpenCon();
           /*
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            */
            Con.Open();
            SqlCommand cms = new SqlCommand(sql, Con);
            return cms;
        }



        /// <summary>
        /// 获取读取对象
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>读取对象</returns>
        protected SqlDataReader GetDreader(string sql)
        {
            SqlDataReader dreader = GetCmd(sql).ExecuteReader(CommandBehavior.CloseConnection);
            return dreader;
        }
    }
}
