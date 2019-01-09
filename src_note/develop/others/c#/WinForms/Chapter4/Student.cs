using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDemo
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {

        /// <summary>
        /// 学生的班主任
        /// </summary>
        public Teacher MyTeacher { get; set; }

        public Student(Teacher teacher)
        {
            this.MyTeacher = teacher;
        }

        //方法重载
        public void Hello(Teacher teacher)
        {
            Console.WriteLine("{0}老师好", teacher.Name);
        }
        public void Hello(SchoolMaster master)
        {
            Console.WriteLine("{0}校长好", master.Name);
            master.AskTeacher(this.MyTeacher);
        }
    }

}
