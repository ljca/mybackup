using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{

    /// <summary>
    /// 科目实体类
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// 科目编号
        /// </summary>
        public int SubjectNo { get; set; }
        /// <summary>
        /// 科目名称
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// 班级号
        /// </summary>
        public int ClassHour { get; set; }

        /// <summary>
        /// 年级编号
        /// </summary>
        public int GradeId { get; set; }

    }
}
