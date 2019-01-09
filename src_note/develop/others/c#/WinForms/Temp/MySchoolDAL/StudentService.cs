using MySchoolModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolDAL
{
    public class StudentService:DBHelper
    {
        /// <summary>
        /// 获取所有的学生
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAllStudent()
        {
            string sql = @"select * from student";
            return GetStudentsBySQL(sql);
        }

        public List<Student> GetStudentByGradeId(int gradeId)
        {
            string sql = @"select * from student where gradeId = " + gradeId;
            return GetStudentsBySQL(sql);
        }

        private List<Student> GetStudentsBySQL(string sql)
        {

            List<Student> list = new List<Student>();

            //包含所有的学生信息
            SqlDataReader dr = ExecuteReader(sql);
            #region
            while (dr.Read())//判断是否存在数据
            {
                //实例化一个实体对象
                Student stu = new Student();
                //给对象的属性赋值
                stu.Address = dr["Address"].ToString();
                stu.BornDate = Convert.ToDateTime(dr["BornDate"]);
                stu.Email = dr["Email"].ToString();
                stu.GradeId = Convert.ToInt32(dr["GradeId"]);
                stu.IDentityCard = dr["IDentityCard"].ToString();
                stu.LoginPwd = dr["LoginPwd"].ToString();
                stu.Phone = dr["Phone"].ToString();
                stu.Sex = Convert.ToBoolean(dr["Sex"]);
                stu.StudentName = dr["StudentName"].ToString();
                stu.StudentNo = Convert.ToInt32(dr["StudentNo"]);

                //将对象添加到集合
                list.Add(stu);
            }
            #endregion
            dr.Close();
            return list;
        }
    }
}
