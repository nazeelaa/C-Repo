using System;
using System.Collections;
using System.Collections.Generic;



namespace StackProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("56");
            stack.Push("30");
            stack.Push("70");
           // stack.Push("Fourth Element");
           // stack.Push("Fifth Element");
            foreach (string item in stack)
            {

                Console.WriteLine(item);

            }
            Console.WriteLine("..................");
            Console.WriteLine(stack.Peek());
        }
    }
}
        //Stack.Pop();
            //foreach (string item in stack) ;
            //{
              //  Console.WriteLine(item);

           // }
             //   Console.WriteLine("..................");
        
                    //Console.WriteLine(Stack.Peek());




