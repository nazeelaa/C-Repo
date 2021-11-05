using System;

namespace Day6practiceproblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Program to use Press Y.");
            char ch1 = Convert.ToChar(Console.ReadLine());
        char consent = ch1;

            while (consent == 'y' || consent == 'Y')
            {
                Console.WriteLine("Enter the choice : \n1.Fibonacci Series. \n2.Perfect Number. \n3.Prime Number.\n4.Reverse Number.\n5.Stop Watch.\n6.Generate Coupon.");
                Console.WriteLine("............................................");
                int key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        FibonacciSeries.fibonacci();
                        break;
                    case 2:
                        PerfectNum.perfectNo();
                        break;
                    case 3:
                        PrimeNum.primeNo();
                        break;
                    case 4:
                        ReverseNum.reverseNo();
                        break;
                    //case 5:
                        //Console.WriteLine("The Program is not Completed");
                        //StopWatch.stopWatch();
                        //break;
                    case 6:
                        CouponNumber.couponNo();
                        break;
                    default:
                        Console.WriteLine("Enter the Given option");
                        break;
                }
                Console.WriteLine("Do you Want to continue press Y.");
                char ch = Convert.ToChar(Console.ReadLine());
                   consent = ch;
            }
        }
    }
}