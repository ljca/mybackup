using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QQManager
{
   
    /// <summary>
    /// 用户信息管理类
    /// </summary>
    class UserManager
    {
        private const string str = "Data Source=.;Initial Catalog=QQ;Integrated Security=True";
        private const string EXCEPT = "";
        private const string ERRMSG = "";

    SqlConnection cn = new SqlConnection(str);
      
        /// <summary>
        /// 
        /// </summary>
        public void DeleteUserInfo()
        {
            cn.Open();

            cn.Close();

        }

        /// <summary>
        /// 
        /// </summary>
        public void DisplayUserInfo()
        {

        }

        public void InsertUserInfo()
        {
        }

        public void JudgeUserInfo()
        {
        }

        public void ShowDesign()
        {
        }

        public void ShowMenu()
        {
        }

        public void ShowUserInfo()
        {
        }

        public void Login()
        {
        }

        public void UpdateOnLineDay()
        {
        }

        public void UpdateUserLevel()
        {
        }
    }
}
