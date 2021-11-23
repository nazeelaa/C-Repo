using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Calculator obj = new Calculator();

            Console.WriteLine("Enter choice");
            Console.WriteLine("1. Addtition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("Enter Two Numbers :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int add = obj.Add(a, b);
                    Console.WriteLine("Addition is " + add);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter Two Numbers :");
                    int c = Convert.ToInt32(Console.ReadLine());
                    int d = Convert.ToInt32(Console.ReadLine());
                    int sub = obj.Sub(c, d);
                    Console.WriteLine("Subtraction is " + sub);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter Two Numbers :");
                    int e = Convert.ToInt32(Console.ReadLine());
                    int f = Convert.ToInt32(Console.ReadLine());
                    int mul = obj.Mul(e, f);
                    Console.WriteLine("Multiplication is " + mul);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter Two Numbers :");
                    int g = Convert.ToInt32(Console.ReadLine());
                    int h = Convert.ToInt32(Console.ReadLine());
                    int div = obj.Div(g, h);
                    Console.WriteLine("Division is " + div);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter the 1 - 4 number.");
                    Console.ReadLine();
                    break;

            }


        }
    }
}
