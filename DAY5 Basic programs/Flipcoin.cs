
using System;
using System.Collections.Generic;
using System.Text;

namespace DAY5_Basic_programs
{
    class FlipCoin
    {
       public static void Flipcoin()
        {
            int noOfTime;
            int noOfHeads = 0;
            int noOfTails = 0;
            int noOfItration = 0;

            Console.WriteLine("How many times you want to flip the coin :");
            noOfTime = int.Parse(Console.ReadLine());


            while (noOfItration < noOfTime)
            {
                noOfItration++;
                Random random = new Random();
                double coinFlip = random.NextDouble();

                if (coinFlip < 1)
                {
                    Console.WriteLine("You got Tails.");
                    noOfTails++;
                }
                else
                {
                    Console.WriteLine("You got Heads.");
                    noOfHeads++;
                }

            }
            double pHead = noOfHeads * 100 / noOfTime;
            Console.WriteLine("Heads is " + pHead + " Percent ");
            double pTail = noOfTails * 100 / noOfTime;
            Console.WriteLine("Tails is " + pTail + " Percent ");
            Console.ReadLine();
        }
    }
}
