using System;

namespace headtail
{
    public class Program
    {
        static void Main(string[] args)
        {
        label1: Console.WriteLine("1.Print the percentage coin Flip");
            Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());
            switch(i)
            {
                case 1:
                    Console.WriteLine("1. Print the percentage coin");
                    PercentageOfHeadTail.PercentageOfHeadTail = new PercentageOfHeadTail();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
            Console.WriteLine("Do you want to continue...yes/no");
            if(Console.ReadKey().KeyChar.ToString()== "YES")
            { goto label1;
            }
            Console.ReadKey();
        }

    }
}
