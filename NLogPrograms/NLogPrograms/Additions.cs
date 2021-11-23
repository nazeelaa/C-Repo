using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace NLogPrograms
{
    class Additions
    {



        static NlogApplication nLog = new NlogApplication();

        public static int Add(int firstNum, int secondNum)
        {
            int sum = 0;

            try
            {

                if (firstNum == 0 || secondNum == 0)
                {
                    nLog.LogDebug("debug successfully");
                    nLog.LogError("first umber or second number is zero");
                    nLog.LogInfo("add method");
                    return 0;
                }
                sum = firstNum + secondNum;
                nLog.LogInfo("addition method executed");
                nLog.LogDebug("debug successfully");
                nLog.LogWarn("first number & second number should not be zero");
                return sum;
            }
            
        Catch(Exception ex)
         {
                Console.WriteLine(ex.ToString());

            }
            return sum;

        }
    }
}
