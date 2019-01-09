using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Model;

namespace TeacherManager.DAL
{
    public class TeacherService : DBService
    {
        /// <summary>
        /// 实例化教师数据类
        /// </summary>
        private GradeService gs = new GradeService();
        public List<Teacher> GetAllTeacher()
        {
            //查询得到数据
            SqlDataReader dr = ExecuteQuery(@"select t.*,g.gname from Grade g,Teacher t
where g.gid = t.gid", null);
            //实例化集合
            List<Teacher> list = new List<Teacher>();
            using (dr)//使用using释放资源
            {
                while (dr.Read())//判断是否有数据并读取
                {
                    Teacher t = new Teacher();//实例化教师对象
                    #region 设置教师对象属性数据
                    t.TeacherName = dr["teacherName"].ToString();
                    t.TeachYear = Convert.ToInt32(dr["teachYear"]);
                    //此处注意：调用年级类的方法 获取年级信息对象
                    t.TeachGrade = gs.ReaderGrade(dr); 
                    t.Age = Convert.ToInt32(dr["age"]);
                    t.Tid = Convert.ToInt32(dr["tid"]);
                    #endregion
                    list.Add(t); //添加对象到集合
                }
            }
            //返回集合对象
            return list;
        }
    }
}
