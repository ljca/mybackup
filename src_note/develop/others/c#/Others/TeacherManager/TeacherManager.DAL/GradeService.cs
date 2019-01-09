using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherManager.Model;

namespace TeacherManager.DAL
{
    public class GradeService : DBService
    {
        public Grade GetGradeById(int gradeId)
        {
            //创建 参数对象 用于给sql的参数赋值
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@gid", gradeId);
            //执行sql获取数据
            SqlDataReader dr = ExecuteQuery("select * from grade where gid=@gid", param);
            using (dr)
            {
                //判断并读取数据
                if (dr.Read())
                {
                    return ReaderGrade(dr);
                }
                return null;
            }
        }

        /// <summary>
        /// 使用DataReader读取数据创建Grade对象
        /// </summary>
        /// <param name="dr">读取数据对象</param>
        /// <returns>年级信息对象</returns>
        public Grade ReaderGrade(SqlDataReader dr)
        {
            Grade g = new Grade(); //创建对象
            try
            {
                //赋值
                g.GradeId = Convert.ToInt32(dr["gid"]);
                g.GradeName = dr["gname"].ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            return g;
        }
    }
}
