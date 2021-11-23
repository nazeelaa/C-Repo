using System;

namespace ReverseNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int perNum = int.Parse(Console.ReadLine());
            int rev = 0;
            while(perNum>0)
            {
                int rem = perNum % 10;
                rev = (rev * 10) + rem;
                perNum = perNum / 10;

            }
            Console.WriteLine("reverse number is:" + rev);
        }

    }
}
