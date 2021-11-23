using System;
using System.Collections.Generic;
using System.Text;

namespace headtail
{
    public class PercentageOfHeadTail
    {
        
        public void PrintHeadTail()
        {
            int head = 0;
            int tail = 0;
            int CoinResult = 0;

            Random random = new Random();

            Console.WriteLine("enter the input of coin flip");
            int readInputfromUserNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < readInputfromUserNum; i++)
            {
                int PercentageOfHeadTail = random.Next(0, 2);
                if (CoinResult==0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }



            }
            double resultHead = (head * 100) / readInputfromUserNum;
            double resultTail = (tail * 100) / readInputfromUserNum;

            Console.WriteLine("head is Flip" + resultHead);
            Console.WriteLine("tail is flip" + resultTail);
            Console.ReadKey();
        }
}
    }
