using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MySchool.DAL
{

    /// <summary>
    /// 辅助类
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static const string CONSTR = ConfigurationManager.ConnectionStrings["CONSTR"].ToString();

        private SqlConnection con;
        /// <summary>
        /// 连接对象
        /// </summary>
        public SqlConnection Con
        {
            get
            {
                return new SqlConnection(CONSTR);
            }

        }


    }
}
