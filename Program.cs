﻿namespace EmployeeeWage;
class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int Emp_Rate_hr = 20;
    public const int Num_Days = 20;

    static void Main(string[] args)
    {
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;

        for (int day = 0; day < Num_Days; day++)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * Emp_Rate_hr;
            totalEmpWage += empWage;
            Console.WriteLine("Emp Wage : " + empWage);
        }
        Console.WriteLine("Total emp wage : " + totalEmpWage);
    }
}

