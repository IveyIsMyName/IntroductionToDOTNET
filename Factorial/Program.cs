using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			BigInteger f = 1;
			for (int i = 1; i<= n; i++)
			{
				Console.Write(i + "! = ");
				f *= i;
                Console.WriteLine(f);
			}
		}
	}
}
