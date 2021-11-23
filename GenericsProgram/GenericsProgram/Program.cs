using System;

namespace GenericsProgram
{
    class Program
    {
        
			public static void toPrint<T>(T[] inputArray)
			{
				foreach (var element in inputArray)
				{
					Console.WriteLine(element);
				}
				Console.WriteLine("-------------------");
			}

			static void Main(string[] args)
			{
				int[] intArray = { 1, 2, 3, 4, 5 };
				double[] doubleArray = { 1.1, 2.2 };
				char[] charArray = { 'n', 'm' };

				Program.toPrint<int>(intArray);
				Program.toPrint<double>(doubleArray);
				Program.toPrint<char>(charArray);

			}

		}
	}

