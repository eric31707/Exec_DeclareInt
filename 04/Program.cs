using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = 10, number2 = 20;
			int temp = number1;
			number1 = number2;
			number2 = temp;
			Console.WriteLine($"對調後的結果:number1 ={number1},number2 ={number2}");
		}
	}
}
