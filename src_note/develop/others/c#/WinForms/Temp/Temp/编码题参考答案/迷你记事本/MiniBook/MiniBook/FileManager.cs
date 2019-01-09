using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MiniBook
{
    class FileManager
    {
        public static bool SaveFile(string fileName, string strToSave)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName,false,Encoding.GetEncoding("GB2312"));
                sw.WriteLine(strToSave);
                sw.Close();
                return true;
            }
            catch (IOException ex)
            {
                // throw new Exception("文件保存异常:"+ex.Message);
                return false;
            }
        }
        public static string OpenFile(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName,Encoding.GetEncoding("GB2312"));
                StringBuilder sb = new StringBuilder();
                string line ="";
                while (true)
                {
                     line = reader.ReadLine();
                     if (line == null)
                     {
                         break;
                     }
                     else
                     {
                         sb.Append(line);
                     }
                }
                reader.Close();
                return sb.ToString();
            }
            catch (IOException ex)
            {
                // throw new Exception("文件保存异常:"+ex.Message);
                return "err";
            }
        }
    }
}
