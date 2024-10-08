//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAY

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = new[] { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			Random rnd = new Random(0); // 0 - Seed value
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(100);
			}
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i] + "\t");
			//}
			//Console.WriteLine();
			
			foreach (int i in arr) //Range-based for
			{
				Console.Write(i + "\t");
			}
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Среднее-арфиметическое элеметов массива: {arr.Average()}");
            Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
            Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");
			Array.Sort(arr);
            Console.WriteLine("Отсортированный массив(возраст.): " + string.Join("\t", arr));
			Array.Reverse(arr);
            Console.WriteLine("Отсортированный массив(убыв.): " + string.Join("\t", arr));

#endif
#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + " ");
				}
				Console.WriteLine();
			}
			//foreach (int i in i_arr_2)
			//{
			//	Console.Write(i + "\t");
			//}
			//Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {i_arr_2.Cast<int>().Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {i_arr_2.Cast<int>().Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {i_arr_2.Cast<int>().Max()}");

			int tempRows = i_arr_2.GetLength (0);
			int tempCols = i_arr_2.GetLength (1);	
			int[] tempArr = new int[tempRows * tempCols];

			int index = 0;
			for (int i = 0; i< tempRows; i++)
			{
				for (int j = 0;j < tempCols; j++)
				{
					tempArr[index++] = i_arr_2[i, j];
				}
			}
			Array.Sort (tempArr);
			index = 0;
			for(int i = 0; i<rows;i++)
			{
				for(int j = 0; j<tempCols; j++)
				{
					i_arr_2[i, j] = tempArr[index++];
				}
			}
			Console.WriteLine("Отсортированный двумерный массив: ");
			for(int i = 0;i<rows;i++)
			{
				for (int j=0; j<cols; j++)
				{
					Console.Write(i_arr_2[i, j] + " ");
				}
                Console.WriteLine();
			}
#endif

#if JAGGED_ARRAY
			int[][] arr_jagged = 
				{
				new int[]{ 0, 1, 1, 2 },
				new int[]{ 3, 5, 8, 13, 21 },
				new int[]{ 34, 55, 89 },
				new int[]{ 144, 233, 377, 610, 987 }
				};
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			}
			
			Console.WriteLine("Сумма элементов массива: ");
			int sum = 0;
			int count = 0;
			foreach (int[] subArr in arr_jagged)
			{
				foreach (int value in subArr)
				{
					sum += value;
					count++;
				}
			}
            Console.WriteLine(sum);

			Console.WriteLine("Среднее-арифметическое элементов массива: ");
			double average = (double)sum/count;
            Console.WriteLine(average);

			int min, max;
			min = max= arr_jagged[0][0];
			foreach(int[] subArr in arr_jagged)
			{
				foreach(int value in subArr)
				{
					if (value < min) min = value;
					if (value > max) max = value;
				}
			}
			Console.WriteLine($"Минимальное значение массива: {min}");
			Console.WriteLine($"Максимальное значение массива: {max}");
			
			for (int i = 0;i < arr_jagged.Length;i++)
			{
				Array.Sort(arr_jagged[i]);
			}
            Console.WriteLine("Отсортированный зубчатый массив: ");
			foreach (int[] subArr in arr_jagged)
			{
                Console.WriteLine(string.Join("\t", subArr));
			}
#endif

		}		
	}
}
