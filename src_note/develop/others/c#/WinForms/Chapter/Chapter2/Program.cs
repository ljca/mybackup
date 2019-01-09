using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fen = new int[] { 67, 89, 99, 77, 84 };
            int[] fen2 = new int[5];
            AddPoint(fen, fen2,10);
            for (int i = 0; i < fen.Length; i++)
            {
                Console.WriteLine("原本的分数："+fen[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < fen.Length; i++)
            {
                
                Console.WriteLine("现在的分数："+fen2[i]);
            }
            
            Console.ReadLine();
        }

        private static void AddPoint(int[] fen, int[] fen2,int addPointNumber)
        {
            for (int i = 0; i < fen.Length; i++)
            {
                fen2[i] = fen[i] + addPointNumber;
                if (fen2[i] >= 100)
                {
                    fen2[i] = 100;
                }
            }
        }
    }
}
