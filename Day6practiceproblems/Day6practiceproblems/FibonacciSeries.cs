using System;
using System.Collections.Generic;
using System.Text;

namespace Day6practiceproblems
{
    class FibonacciSeries
    {
      
            public static void fibonacci()
            {
                int a = 0, b = 1, c, i, n;

                Console.Write("Enter the number of elements: ");
                n = int.Parse(Console.ReadLine());

                Console.Write(a + " " + b + " "); //printing 0 and 1    

                for (i = 2; i < n; ++i) //loop starts from 2 because 0 and 1 are already printed    
                {
                    c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }

                Console.ReadLine();
            }
        }
    }
