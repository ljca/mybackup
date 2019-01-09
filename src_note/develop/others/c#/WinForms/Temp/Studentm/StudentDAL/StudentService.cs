using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentModel;
using System.Data.SqlClient;
using System.Data;

namespace StudentDAL
{

    /// <summary>
    /// 数据层学生服务类
    /// </summary>
    public class StudentService:DBHelper
    {
        /// <summary>
        /// 获取所有学生
        /// </summary>
        /// <returns>所有学生</returns>
        public List<Student_Model> GetAllStudent(string sql)
        {
            List<Student_Model> studentlist = new List<Student_Model>();
            Student_Model student = new Student_Model();
            try
            {
                SqlDataReader dreader = GetDreader(sql);
                while (dreader.Read())
                {
                    student.Stu_Id = Convert.ToInt32(dreader["stu_id"]);
                    student.Stu_Name = dreader["stu_name"].ToString();
                    student.Stu_Sex = dreader["stu_sex"].ToString();
                    student.Stu_Email = dreader["stu_email"].ToString();
                    student.Stu_Age = Convert.ToInt32(dreader["stu_age"]);

                    studentlist.Add(student);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return studentlist;
        }

        public void GetSex()
        {

 
        }


    }
}
