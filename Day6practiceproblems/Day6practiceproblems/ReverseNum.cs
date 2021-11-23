using System;
using System.Collections.Generic;
using System.Text;

namespace Day6practiceproblems
{
    class ReverseNum
    {
        public static void reverseNo()
        {
            int n, rev = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + rev);

            Console.ReadLine();
        }
    }
}
   