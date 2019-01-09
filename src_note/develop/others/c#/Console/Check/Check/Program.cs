using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Check_1 cek = new Check_1();
            
            Console.WriteLine("请输入用户名：");
            string uNe = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string psd = Console.ReadLine();
            cek.CheckUserInfo(uNe, psd);

        }
    }
}
