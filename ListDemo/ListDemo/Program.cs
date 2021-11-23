using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(23);
            list.Add(35);
            foreach (int item in list)
            {
                Console.WriteLine(item);

            }
            List<string> list1 = new List<string>();
            list1.Add("List1");
            list1.Add("list2");

            foreach(string item in list1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
