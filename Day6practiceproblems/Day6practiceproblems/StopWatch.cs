using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Day6practiceproblems
{
    class SimulateStopWatch
    {
       

        public  void startStopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Console.WriteLine("enter number");
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(5);

            }
            stopwatch.Stop();
            Console.WriteLine("elapsed time{0:hh\\mm\\ss}", stopwatch.Elapsed);
        }
    


   

}
}
