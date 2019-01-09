using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolDAL
{
    public class AdminService : DBHelper
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="loginPwd"></param>
        /// <returns></returns>
        public bool Login(string loginId,string loginPwd)
        {
            if (
                string.IsNullOrEmpty(loginId)
                ||
                string.IsNullOrEmpty(loginPwd)
                )
            {
                throw new Exception("用户名和密码都不能为空");
            }
            //数据库连接对象
            SqlConnection conn = Conn;
            //构建参数化sql
            string sql = @"
    select * from admin where loginId=@loginId 
and loginPwd=@loginPwd
";
            using (conn)
            {
                //
                SqlCommand cmd = new SqlCommand(sql, conn);
                //
                cmd.Parameters.Add(new SqlParameter("@loginId", loginId));
                //
                cmd.Parameters.AddWithValue("@loginPwd", loginPwd);
                conn.Open();
                return cmd.ExecuteScalar() != null; 
            }
            
        }
    }
}
