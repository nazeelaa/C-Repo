using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseNum
{
    public class Stopwatch
    {
        public static void Main(String[] args)
        {
            //public static void stopwatch()
            {
                Console.WriteLine("enter the start time");
                string str1 = Console.ReadLine();
                Stopwatch watch = null;
                if (str1.Equals("start"))
                {
                    new Stopwatch();
                    watch.start();

                }
                Console.WriteLine("enter end time");
                string str2 = Console.ReadLine();
                if (str2.Equals("stop"))
                {
                    watch.stop();

                }
            }
        }
    }
}
        

    
