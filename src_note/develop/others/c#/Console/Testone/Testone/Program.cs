using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Testone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Other> other = new List<Other>();
            Other[] otherone = new Other[6];
            otherone[0] = new Other();
            otherone[0].Name = "X";
            otherone[0].Age = 18;
            other.Add(otherone[0]);
            foreach (Object obe in other)
            {
                Other or = (Other)obe;
                Console.WriteLine("名字：" + or.Name + "，年龄：" + or.Age);
            }
            Console.ReadLine();

            /* 哈希表的用法*/
            Hashtable hashone = new Hashtable();
            hashone.Add(otherone[0].Age,otherone[0].Name);
            foreach (DictionaryEntry item in hashone)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("名字：" + item.Key + "，年龄：" + item.Value);
            }
            Console.ReadLine();
        }
    }
}
