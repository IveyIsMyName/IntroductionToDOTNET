using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{

			while (true)
			{
				Console.WriteLine("Введите арифмитическое выражение: ");
				string input = Console.ReadLine();
				string[] operands = input.Split('+', '-', '*', '/');
				double a = Convert.ToDouble(operands[0]);
				double b = Convert.ToDouble(operands[1]);

				if (input.Contains("+")) Console.WriteLine($"{a} + {b} = {a + b}");
				else if (input.Contains("-")) Console.WriteLine($"{a} - {b} = {a - b}");
				else if (input.Contains("*")) Console.WriteLine($"{a} * {b} = {a * b}");
				else if (input.Contains("/")) if (b != 0) Console.WriteLine($"{a} / {b} = {a / b}"); else Console.WriteLine("Ошибка! Деление на ноль");
				else Console.WriteLine("Ошибка! Неверная операция"); 
			}
		}
	}
}
