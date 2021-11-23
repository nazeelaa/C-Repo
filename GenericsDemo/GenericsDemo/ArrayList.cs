using System;
using System.Collections.Generic;
using System.Text;
using static GenericsDemo.Program;

namespace GenericsDemo
    {
        public class ArrayList
        {

            public static void Main()
            {
                int[] intArray = { 1, 2, 3, 4, 5 };
                double[] doubleArray = { 1.1, 2.2, 3.3 };
                char[] charArray = { 'b', 'n' };

                new PrintArray<int>(intArray).toPrint();
                new PrintArray<double>(doubleArray).toPrint();
                new PrintArray<char>(charArray).toPrint();


            }
        }

    }


