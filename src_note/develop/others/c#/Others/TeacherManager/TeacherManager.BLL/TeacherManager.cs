using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.DAL;
using TeacherManager.Model;

namespace TeacherManager.BLL
{
    public class TeacherManager
    {
        /// <summary>
        /// 实例化教师数据类
        /// </summary>
        private TeacherService ts = new TeacherService();

        /// <summary>
        /// 获取所有的教师信息
        /// </summary>
        /// <returns>返回教师集合对象</returns>
        public List<Teacher> GetAllTeacher()
        {
            //获取列表
            return ts.GetAllTeacher();
        }
    }
}
