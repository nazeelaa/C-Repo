using System;
using System.Collections.Generic;
using System.Text;

namespace Day6practiceproblems
{
    class CouponNumber
    {
        public static void couponNo()
        {
            try
            {
                Console.WriteLine("enter the number for genertaing the coupon number");
                int n = int.Parse(Console.ReadLine());
                int j = 0;
                int i = 0;
                int k;
                int[] arr = new int[n];
                for (k = 0; j < n; k++)
                {
                    int flag = 0;
                    Random random = new Random();
                    int result = random.Next(n);
                    for (i = 0; i < j; i++)
                    {
                        if (arr[i] == result)
                        {
                            flag = 1;
                            break;
                        }
                        if (flag == 0)
                        {
                            arr[j] = result;
                            j++;

                        }
                    }
                    Console.WriteLine("No of random call:" + k);
                    Console.WriteLine("No of code stored:" + j);
                    for (int l = 0; l < j; l++)
                    {
                        Console.WriteLine(arr[1]);

                    }
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}




    
