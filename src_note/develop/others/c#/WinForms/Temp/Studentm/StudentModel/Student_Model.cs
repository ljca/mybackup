using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentModel
{
    /// <summary>
    /// 学生实体类
    /// </summary>
    public class Student_Model
    {

        /// <summary>
        /// 学号
        /// </summary>
        public int Stu_Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Stu_Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Stu_Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Stu_Sex { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Stu_Email { get; set; }


    }
}
