using StudentDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentModel;

namespace StudentBLL
{
    public class StudentManage
    {
        /// <summary>
        /// 获取学生，并添加到集合中
        /// </summary>
        /// <returns>返回学生集合</returns>
        public List<Student_Model> GetStudent()
        {
            string sql = "select * from Student";
            StudentService stutmp = new StudentService();
           return stutmp.GetAllStudent(sql);
        }
    }
}
