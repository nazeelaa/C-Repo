using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class CalculateLength
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparision Computation Program");
            Console.WriteLine("Enter Co-ordinate X1, X2, Y1, Y2 : ");

            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Co-ordinate X1 is: " + X1 + "\nCo-ordinate X2 is: " + X2 + "\nCo-ordinate Y1 is: " + Y1 + "\nCo-ordinate Y2 is: " + Y2);

            double Lenth_of_line = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

            Console.WriteLine("Your Lenth of line is: " + Lenth_of_line);
            Console.ReadLine();

        }
    }
}
