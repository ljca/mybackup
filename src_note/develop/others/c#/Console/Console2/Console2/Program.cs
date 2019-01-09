/*
 * Created by SharpDevelop.
 * User: YL_HH_GG
 * Date: 2015/11/24 星期二
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Console2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i = 1, result = 0;
			while (i < 7) {
				i++;
				result = result + i;
				if (i > 6) {
					break;
				} else {
					continue;
				}
			}
			Console.WriteLine(result);
			Console.ReadKey(true);
		}
		
	}
}