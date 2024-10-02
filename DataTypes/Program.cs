using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimiter = "\n-------------------------\n";
		static void Main(string[] args)
		{
			#region BOOL
			//Console.WriteLine("Hello Datatype!");
			//         Console.WriteLine(sizeof(bool));
			//Console.WriteLine(true);
			//Console.WriteLine(false);
			//         Console.WriteLine(Boolean.FalseString); 
			#endregion

			Console.WriteLine("Byte:");
			Console.WriteLine(sizeof(byte));
			Console.WriteLine(byte.MinValue);
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(delimiter);

            Console.WriteLine("SByte:");
            Console.WriteLine(sizeof(sbyte));
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("Decimal:");
			Console.WriteLine(sizeof(decimal));
			Console.WriteLine(decimal.MinValue);
			Console.WriteLine(decimal.MaxValue);
			Console.WriteLine(delimiter);

			//Console.WriteLine(5ul.GetType());

            Console.WriteLine();
			int a = 2000000000;
			int b = 4;
			try
			{
				Console.WriteLine(a * b);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
	}
}
