using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            Calculator obj = new Calculator();

            char consent = 'y';
            while (consent == 'y')
            {
                Console.WriteLine("Enter Choice");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Enter Two Numbers :");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int Add = obj.getAdd(num1, num2);
                        Console.WriteLine("Addition is " + Add);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Enter Two Numbers :");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        int Sub = obj.getSub(num3, num4);
                        Console.WriteLine("Subtraction is " + Sub);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Enter Two Numbers :");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        int num6 = Convert.ToInt32(Console.ReadLine());
                        int Mul = obj.getMul(num5, num6);
                        Console.WriteLine("Multiplication is " + Mul);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Enter Two Numbers :");
                        int num7 = Convert.ToInt32(Console.ReadLine());
                        int num8 = Convert.ToInt32(Console.ReadLine());
                        int Div = obj.getDiv(num7, num8);
                        Console.WriteLine("Division is " + Div);
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("There is no other option");
                        break;
                }
            }
        }
    }
}
