using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherManager.Model
{
    /// <summary>
    /// 教师实体类
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Tid { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string TeacherName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 教龄
        /// </summary>
        public int TeachYear { get; set; }
        /// <summary>
        /// 年级 注意： 此处使用的类型为年级实体类
        /// </summary>
        public Grade TeachGrade { get; set; }
    }
}
