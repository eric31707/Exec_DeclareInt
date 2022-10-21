using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number;
			number = 120 / 7;
			int number1;
			number1 = 120 % 7;
			Console.WriteLine("120/7的商是" + number.ToString() + "餘數是" + number1.ToString());
			Console.ReadLine();
		}
	}
}
