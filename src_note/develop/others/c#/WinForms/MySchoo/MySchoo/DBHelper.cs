using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MySchoo
{
    class DBHelper
    {
        /// <summary>
        /// 用于连接数据库的连接字符串
        /// </summary>
        private string CONSTR = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
       
        /// <summary>
       /// 用于连接数据库的连接对象
       /// </summary>
        public const string cn = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True";

        SqlConnection CN = new SqlConnection(cn);
        //private SqlConnection cn;
        //public SqlConnection CN
        //{
        //    get
        //    {
        //        if(cn == null)
        //        {
        //            cn = new SqlConnection(CONSTR);
        //        }
        //        return cn;
        //    }
           
        //}

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        { 
            if(CN.State == ConnectionState.Closed)
            {
                CN.Open();
            }
            else if(CN.State == ConnectionState.Broken)
            {
                CN.Close();
                CN.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        { 
            if(CN.State == ConnectionState.Broken || CN.State == ConnectionState.Open)
            {
                CN.Close();
            }
        }


    }
}
