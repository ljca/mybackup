using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Comman
{
    public class Sectu
    {
        /// <summary>
        /// 
        /// </summary>
        public static void GetMd5String(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] md5byte = System.Text.Encoding.Default.GetBytes(str);
            byte[] temp = md5.ComputeHash(md5byte);
            md5.Clear();
            for (int i = 0; i < temp.Length - 1; i++)
            {

            }
        }
    }
}
