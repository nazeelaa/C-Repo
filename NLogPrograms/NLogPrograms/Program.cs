using System;
using System.Diagnostics;
namespace NLogPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to NLOG");
            //Additions additions = new Additions();
            Additions.Add(20, 5);
            Console.ReadKey();

        }
    }
}
