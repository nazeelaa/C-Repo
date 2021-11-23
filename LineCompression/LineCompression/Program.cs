using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace LineCompression
{
    class Program
    {
         

        public static void Length()
        
        
        {
            Console.WriteLine("enter your co-ordinates X1,X2,Y1,Y2");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Co-ordinates X1 is:" + X1 + "\n Co - ordinates X2 is:" + X2 + "\n Co - ordinates Y1 is:" + Y1 + "\n Co - ordinates Y2 is:" + Y2);
           Double Length_of_line = Math.Sqrt(Math.Pow((X2 - X1), 2) +  Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("YOUR LENGTH OF LINE IS : "+ Length_of_line); 
        } 


        }
    }

