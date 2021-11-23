using System;

namespace WithoutGenerics
{ 

        
            public class Program
        {
            public static void toPrint(int[] inputArray)
            {
                foreach (int element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine(".........................");
            }

            public static void toPrint(double[] inputArray)
            {
                foreach (double element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine(".........................");
            }

            public static void toPrint(char[] inputArray)
            {
                foreach (char element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine(".........................");
            }

            static void Main(string[] args)
            {
                int[] intArray = { 1, 2, 3, 4 };
                double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
                char[] charArray = { 'B', 'R', 'T', 'D' };

                Program.toPrint(intArray);
                Program.toPrint(doubleArray);
                Program.toPrint(charArray);
                Console.WriteLine("Hello World!");
            }
        }
    }
