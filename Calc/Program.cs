using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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
				input = input.Replace('.', ','); //метод Replace() заменяет первый указанный символ вторым (или первую указанную строку второй) и возвращает измененную строку, при этом исходная строка остается неизменной
				char[] delimiters = new char[] { '+', '-', '*', '/' };
				string[] operands = input.Split(delimiters);
				try
				{
					double a = Convert.ToDouble(operands[0]);
					double b = Convert.ToDouble(operands[1]);
					//метод Split(...), который принимает набор разделителей
					//и возвращает токены ("разрезанную строку" по указанным разделителям
					//в виде массива строк)
					#region IFcalc
					//if (input.Contains("+")) Console.WriteLine($"{a} + {b} = {a + b}");
					//else if (input.Contains("-")) Console.WriteLine($"{a} - {b} = {a - b}");
					//else if (input.Contains("*")) Console.WriteLine($"{a} * {b} = {a * b}");
					//else if (input.Contains("/")) if (b != 0) Console.WriteLine($"{a} / {b} = {a / b}"); else Console.WriteLine("Ошибка! Деление на ноль");
					//else Console.WriteLine("Ошибка! Неверная операция");  
					#endregion

					//Метод IndexOfAny() возвращает индекс найденного символа, в данном случае символа из массива 'delimiters'
					switch (input[input.IndexOfAny(delimiters)])
					{
						case '+': Console.WriteLine($"{a} + {b} = {a + b}"); break;
						case '-': Console.WriteLine($"{a} - {b} = {a - b}"); break;
						case '*': Console.WriteLine($"{a} * {b} = {a * b}"); break;
						case '/': if (b != 0) Console.WriteLine($"{a} / {b} = {a / b}"); else Console.WriteLine("Error! Can't divide by zero"); break;
					}
				}
				catch (Exception ex)
				{
                    Console.WriteLine(ex.Message);
				}
			}
		}
	}
}
