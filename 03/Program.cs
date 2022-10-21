using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入數字");
			string number = Console.ReadLine();
			int number1 = Convert.ToInt32(number) % 2;
			string result = (number1 == 1) ? "奇數" : "偶數";
			Console.WriteLine(result);
		}
	}
}
