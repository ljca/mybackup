using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.DAL
{
    public class DBHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string CONSTR = @"Data Source=.;Initial Catalog=MySchool;Integrated Security=True";

        private SqlConnection con;
        /// <summary>
        /// 连接对象
        /// </summary>
        public SqlConnection Con 
        {
            get { return con; }
        }
    }
}
