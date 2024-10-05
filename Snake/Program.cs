using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Title = "Snake";

			//Инициализация позиции курсора внутри границ
			int x = Console.WindowWidth / 2;
			int y = Console.WindowHeight / 2;

			//Скрываем стандартный курсор консоли
			Console.CursorVisible = false;

			//Методы для создания границ и нового курсора
			DrawBorders();
			DrawCursor(x, y);

			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				ClearCursor(x, y);

				switch (keyInfo.Key)
				{
					case ConsoleKey.W:
					case ConsoleKey.UpArrow:
						if (y > 1) y--; break;
					case ConsoleKey.S:
					case ConsoleKey.DownArrow:
						if (y < Console.WindowHeight - 2) y++; break;
					case ConsoleKey.D:
					case ConsoleKey.RightArrow:
						if (x < Console.WindowWidth - 2) x++; break;
					case ConsoleKey.A:
					case ConsoleKey.LeftArrow:
						if (x > 1) x--; break;
					case ConsoleKey.Escape:
						return;
					default: break;
				}
				//Рисуем курсор на новой позиции
				DrawCursor(x, y);
			}
		}

		static void DrawBorders()
		{
			int width = Console.WindowWidth;
			int height = Console.WindowHeight;

			//Верхняя и нижняя границы
			for (int x = 0; x < width; x++)
			{
				Console.SetCursorPosition(x, 0);
				Console.Write("━");
				Console.SetCursorPosition(x, height - 1);
				Console.Write("━");
			}

			//Левая и правая границы
			for (int y = 0; y < height; y++)
			{
				Console.SetCursorPosition(0, y);
				Console.Write("┃");
				Console.SetCursorPosition(width - 1, y);
				Console.Write("┃");
			}

			//Углы
			Console.SetCursorPosition(0, 0);
			Console.Write("┏");
			Console.SetCursorPosition(width - 1, 0);
			Console.Write("┓");
			Console.SetCursorPosition(0, height - 1);
			Console.Write("┗");
			Console.SetCursorPosition(width - 1, height - 1);
			Console.Write("┛");
		}

		static void DrawCursor(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write("₷");
		}

		static void ClearCursor (int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(" ");
		}
	}
}
