using System;
namespace EmployeeManagement
{
	public class EmployeeWage
	{
		public static void DailyWage()
		{
			int IS_FULL_TIME = 1;
			int EMP_RATE = 20;
			int empHrs = 0;
			int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
			if (empCheck == IS_FULL_TIME)
			{
				empHrs = 8;
			}
			else
			{
				empHrs = 0;
			}
			empWage = empHrs * EMP_RATE;
			Console.WriteLine("Emp Wage :" + empWage);

        }
	}
}

