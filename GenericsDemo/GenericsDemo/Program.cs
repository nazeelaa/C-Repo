using System;

namespace GenericsDemo
{
    class Program
    {
      
            public class PrintArray<T>
        {
            private T[] inputArray;
            public PrintArray(T[] inputArray)
            {
                this.inputArray = inputArray;
            }

            public void toPrint()
            {
                foreach (var element in inputArray)
                {
                    Console.WriteLine(element);
                }
            }

        }
    }
}

