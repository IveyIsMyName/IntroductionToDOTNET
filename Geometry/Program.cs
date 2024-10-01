#define SQUARE
#define TRIANGLE_1
#define TRIANGLE_2
#define TRIANGLE_3
#define ROMB
#define PLUS_MINUS
#define HARD_CHESS

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер фигуры: ");
			int n = Convert.ToInt32(Console.ReadLine());
#if SQUARE
			Console.ForegroundColor = ConsoleColor.Green;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			} Console.WriteLine();
#endif
#if TRIANGLE_1
			Console.ForegroundColor = ConsoleColor.Blue;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			} Console.WriteLine();
#endif
#if TRIANGLE_2
			Console.ForegroundColor = ConsoleColor.Red;
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if TRIANGLE_3
			Console.ForegroundColor = ConsoleColor.Yellow;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++) Console.Write(" ");
				for (int j = i; j < n; j++) Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if ROMB
			Console.ForegroundColor = ConsoleColor.Cyan;
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
				for (int j = 0; j < i; j++) Console.Write("  "); Console.Write("\\");
				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
				for (int j = i; j < n - 1; j++) Console.Write("  "); Console.Write("/");
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if PLUS_MINUS
			Console.ForegroundColor = ConsoleColor.Magenta;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i % 2 == j % 2) Console.Write('+');
					else Console.Write('-');
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if HARD_CHESS
			Console.ForegroundColor = ConsoleColor.Gray;
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					Console.Write(Convert.ToBoolean(i / n & 1 ^ j / n & 1) ? "  " : "* ");
				}
				Console.WriteLine();
			} 
#endif
			//ASCII?????????
			for(int i = 0;i<256;i++)
			{
				if(i%16 == 0) Console.WriteLine();
				else Console.Write(Convert.ToChar(i));
			}
			Console.WriteLine();
		}
	}
}
