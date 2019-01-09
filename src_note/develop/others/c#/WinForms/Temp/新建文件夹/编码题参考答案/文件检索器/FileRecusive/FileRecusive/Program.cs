using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace FileRecusive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入指定目录：");
            string filePath = Console.ReadLine() ;

            try
            {
                DirectoryInfo dir = new DirectoryInfo(filePath);

                //检查目录是否存在
                if (!dir.Exists)
                {
                    Console.WriteLine("指定的目录不存在");
                }
                else
                {
                    Query(dir);
                    Console.WriteLine("目录中的文件类型，文件个数,分类文件总大小:");
                    foreach (DictionaryEntry de in hashTable)
                    {

                        Console.Write("文件类型: " + de.Key);
                        Console.Write(" ");
                        Console.WriteLine("文件数量: " + de.Value);
                    }
                    Console.WriteLine("当前目录的总大小：");
                    Console.WriteLine(Math.Round(fileLength / 1024.0 / 1024 , 1) + "MB");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
        static Hashtable hashTable = new Hashtable();
        static Int64 fileLength = 0;
        static void Query(DirectoryInfo dir)
        {
            //遍历文件
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                fileLength += file.Length;//文件大小
                if (!hashTable.Contains(file.Extension))//
                {
                    hashTable.Add(file.Extension, 1);
                }
                else
                {
                    Int64 fileCount =Convert.ToInt64(hashTable[file.Extension]);
                    fileCount++;
                    hashTable[file.Extension] = fileCount;
                }
            }
            foreach(DirectoryInfo item in dir.GetDirectories())
            {
                Query(item);
            }
        }
    }
}
