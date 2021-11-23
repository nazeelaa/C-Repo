using System;

namespace DelegateProgram
{
    public class Program
    {
        public delegate void MyDelegate(string msg);
        static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            del("hello nazeela");
            del = ClassB.MethodB;
            del("HIIIII");
        }
    }
    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("called ClassA.MethodA() with parameter" + message);
        }
    }
    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("called ClassB.MethodB() with parameter" + message);
        }
    }
}
