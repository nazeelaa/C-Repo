using System;
using System.Collections.Generic;
using System.Text;

namespace Day13PracticePrograms
{
    class CompareNumber
    {
        public static void compareNo()
        {
            int x = 18, y = 15, z = 12;

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
    

