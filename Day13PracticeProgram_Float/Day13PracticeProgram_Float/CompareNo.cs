using System;
using System.Collections.Generic;
using System.Text;

namespace Day13PracticeProgram_Float
{
    class CompareNo
    {

        public static void compareNo()
        {
            double x = 34.3, y = 45.8, z = 42.5;

            if (x.CompareTo(y) > 0 && x.CompareTo(z) > 0 || x.CompareTo(y) >= 0 && x.CompareTo(z) > 0 || x.CompareTo(y) > 0 && x.CompareTo(z) > 0)
            {
                Console.WriteLine(x + " Greater than " + y + " and " + z);
            }
            else if (y.CompareTo(x) > 0 && y.CompareTo(z) > 0 || y.CompareTo(x) >= 0 && y.CompareTo(z) > 0 || y.CompareTo(x) > 0 && y.CompareTo(z) > 0)
            {
                Console.WriteLine(y + " Greater than " + x + " and " + z);
            }
            else if (z.CompareTo(x) > 0 && z.CompareTo(y) > 0 || z.CompareTo(x) >= 0 && z.CompareTo(y) > 0 || z.CompareTo(x) > 0 && z.CompareTo(y) > 0)
            {
                Console.WriteLine(z + " Greater than " + x + " and " + y);
            }
        }
    }
}
    