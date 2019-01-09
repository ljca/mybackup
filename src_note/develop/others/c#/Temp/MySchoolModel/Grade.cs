using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 年级实体类,描述了年级的字段信息
    /// </summary>
    public class Grade
    {

        /// <summary>
        /// 年级编号
        /// </summary>
        public int GradeId { get; set; }

        /// <summary>
        /// 年级名称
        /// </summary>
        public string GradeName { get; set; }
    }
}
