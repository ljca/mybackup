using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDemo
{
    /// <summary>
    /// 老师类
    /// </summary>
    public class Teacher
    {
        public string Name { get; set; }
        public Teacher(string name)
        {
            this.Name = name;
        }
    }

}
