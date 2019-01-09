using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 代表数据库中Student表
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学号
        /// </summary>
        public int StudentNo { get; set; }
        /// <summary>
        /// 学生名字
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 性别 true:男 false：女
        /// </summary>
        public bool Sex { get; set; }
        /// <summary>
        /// 年级编号
        /// </summary>
        public int GradeId { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BornDate { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IDentityCard { get; set; }
    }
}
