using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDemo
{
    /// <summary>
    /// 校长类
    /// </summary>
    public class SchoolMaster
    {
        public string Name { get; set; }
        public SchoolMaster(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 询问学生班主任
        /// </summary>
        public void AskTeacher(Teacher teacher)
        {
            Console.WriteLine("原来你的班主任是:老{0}",teacher.Name);
        }
    }
}
