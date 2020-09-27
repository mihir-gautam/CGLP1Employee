using System;

namespace EmployeePartTimeUC
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Part Time Emp Wage : " + empWage);
        }
    }
}
