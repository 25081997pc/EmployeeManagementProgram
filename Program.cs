using System;
namespace EmployeeManagement
{
    class Program
    {
        //The method is Adding Part Time Employee Wage
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empChk = random.Next(3);

            if (empChk == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empChk == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("empWage :" + empWage);
        }     
    }
}