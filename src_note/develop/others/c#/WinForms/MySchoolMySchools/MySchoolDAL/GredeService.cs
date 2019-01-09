using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Models;
using System.Data.SqlClient;

namespace MySchool.DAL
{
    public class GredeService：DBHelper
    {
        /// <summary>
        /// 返回年级集合
        /// </summary>
        /// <param name="iGradeID">年级编号</param>
        /// <returns>年级集合</returns>
        public static List<Grade> GetGradeId(int iGradeID)
        {
            List<Grade> gradelist = new List<Grade>();
            string sql = @"select * from Grade";
            SqlCommand cmd = new SqlCommand(sql);
            return gradelist;
        }
    }
}
