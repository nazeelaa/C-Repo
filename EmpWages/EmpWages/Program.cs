using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    class Emp_Wages
    {
        // Case Statement

        public const int IS_PART_TIME = 2;
        public const int IS_FULL_TIME = 1;

        // Calculator Emp Monthly Wages

        public const int NUM_OF_WORKING_DAYS = 20;

        // Employee Wages Using While Loop

        public const int MAX_HRS_IN_MONTH = 100;

        public static void Main()
        {
            // Employee Wage Attendence Present or Absent

            //int IS_FULL_TIME = 1;
            Random random = new Random();
            int result = random.Next(0, 2);

            if (result == IS_FULL_TIME)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");

            // Employee Daily Wages

            int EMP_RATE_PER_HOUR = 20, empHrs = 0, empWage = 0;
            int empCheck = result;

            if (empCheck == 1)
            {
                if (empCheck == IS_FULL_TIME)
                {
                    empHrs = 8;
                }
                else
                {
                    empHrs = 0;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine(" Employee Wages :" + empWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            // Part Time Employee Wages

            //int IS_PART_TIME = 2;
            int EMP_WAGE_PER_HOUR = 20;

            //Random random1 = new Random();
            int empChecks = random.Next(0, 3);

            if (empCheck == 1)
            {
                if (empChecks == IS_PART_TIME)
                {
                    empHrs = 4;
                }
                else if (empChecks == IS_FULL_TIME)
                {
                    empHrs = 8;
                }
                else
                {
                    empHrs = 0;
                }
                empWage = empHrs * EMP_WAGE_PER_HOUR;
                Console.WriteLine("Employee Wages is : " + empWage);
            }

            else
            {
                Console.WriteLine("Employee is Absent");
            }

            // Case Statement for Employee Wages

            if (empCheck == 1)
            {
                switch (empChecks)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_WAGE_PER_HOUR;
                Console.WriteLine(" Employee Wages : " + empWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            // Calculator Employee Monthly Wages

            int empwage = 0, totalempwage = 0;

            if (empCheck == 1)
            {
                for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
                {

                    int empCheckes = random.Next(0, 3);
                    switch (empCheckes)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    empwage = empHrs * EMP_RATE_PER_HOUR;
                    totalempwage += empwage;
                    Console.WriteLine("Employee Wages of day : " + (day + 1) + " is : " + empwage);
                }
                Console.WriteLine("Total Employee Wages : " + totalempwage);
            }

            else
            {
                Console.WriteLine("Employee is Absent");
            }

            // Employee Wages Using While Loop

            int totalEmpHrs = 0, totalWorkingDays = 0;

            if (empCheck == 1)
            {
                while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
                {
                    totalWorkingDays++;
                    //Random random = new Random();
                    //int empCheck = random.Next(0, 3);
                    int empCheckes = random.Next(0, 3);
                    switch (empCheckes)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days:" + totalWorkingDays + " Employee Hours :" + empHrs);
                }
                int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Employee Wages : " + totalEmpWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            // Employee Wages Using Method

            if (empCheck == 1)
            {
                while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < MAX_HRS_IN_MONTH)
                {
                    totalWorkingDays++;
                    //Random random = new Random();
                    int empCheckes = random.Next(0, 3);
                    switch (empCheckes)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day :" + totalWorkingDays + " Employee Wages : " + empHrs);
                }
                int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Employee Wages : " + totalEmpWage);

            }
            else
            {
                Console.WriteLine(" Employee is Absent ");
            }

            Console.ReadLine();
        }
    }
}
