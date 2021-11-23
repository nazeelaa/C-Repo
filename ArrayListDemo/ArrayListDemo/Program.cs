using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Bridgelabz");
            arrayList.Add(2);
            arrayList.Add(2.3);
            arrayList.Add('S');
            foreach(var item in arrayList)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine(arrayList.IndexOf('2'));
            int c = arrayList.Count;
            Console.WriteLine("...............");
            Console.WriteLine("count" + c);

        }
    }
}
