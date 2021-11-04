using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison2
{
    class CheckTwoLineEqual
    {
        int X1, X2, Y1, Y2;
        double Lenth_of_Line;

        // Function to Take the Co-ordinates
        public void AcceptLineCoordinates()
        {
            Console.WriteLine("Enter Co-ordinate X1,X2,Y1,Y2:");
            X1 = Convert.ToInt32(Console.ReadLine());
            X2 = Convert.ToInt32(Console.ReadLine());
            Y1 = Convert.ToInt32(Console.ReadLine());
            Y2 = Convert.ToInt32(Console.ReadLine());
        }

        // Function to Display the Line Co-ordinates
        public void DisplayLineCoordinates(int X1, int X2, int Y1, int Y2)
        {
            Console.WriteLine("Co-ordinate X1 is: " + X1 + "\nCo-ordinate X2 is: " + X2 + "\nCo-ordinate Y1 is: " + Y1 + "\nCo-ordinate Y2 is: " + Y2);
        }

        // Function to Calculate the Length of Line
        public double CalculateLengthofLine(int X1, int X2, int Y1, int Y2)
        {
            Lenth_of_Line = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            return Lenth_of_Line;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparision Computation Program");

            CheckTwoLineEqual lineobject = new CheckTwoLineEqual();

            // Collect the values of First Line and Calculate. 
            Console.WriteLine("Enter The First Line Co-Ordinates :");
            lineobject.AcceptLineCoordinates();

            Console.WriteLine("The First Line Co-ordinates are :");
            lineobject.DisplayLineCoordinates(lineobject.X1, lineobject.X2, lineobject.Y1, lineobject.Y2);
            //Calculating the First Line
            lineobject.CalculateLengthofLine(lineobject.X1, lineobject.X2, lineobject.Y1, lineobject.Y2);
            double Lenth_of_First_Line = lineobject.Lenth_of_Line;

            Console.WriteLine("The first line length is :" + Lenth_of_First_Line);

            // Collect the values of Second Line and Calculate.
            Console.WriteLine("Enter The Second Line Co-ordinates :");
            lineobject.AcceptLineCoordinates();

            Console.WriteLine("The Second Line Co-Ordinates are :");
            lineobject.DisplayLineCoordinates(lineobject.X1, lineobject.X2, lineobject.Y1, lineobject.Y2);
            //Calculating the Second Line
            lineobject.CalculateLengthofLine(lineobject.X1, lineobject.X2, lineobject.Y1, lineobject.Y2);
            double Lenth_of_Second_Line = lineobject.Lenth_of_Line;

            Console.WriteLine("The second line length is :" + Lenth_of_Second_Line);

            // Checking if Both the Lines are Equal or not.
            if (Lenth_of_First_Line == Lenth_of_Second_Line)
            {
                Console.WriteLine("The Two lines Are Equals");
            }
            else
            {
                Console.WriteLine("The Two lines Are Not Equals");
            }
            Console.ReadLine();
        }
    }
}
