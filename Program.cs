﻿using System;
namespace EmployeeManagement
{
    class Program
    {
        //The method is calculating daily Employee Wage
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empChk = random.Next(2);

            if (empChk == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("empWage : " + empWage);
        }     
    }
}