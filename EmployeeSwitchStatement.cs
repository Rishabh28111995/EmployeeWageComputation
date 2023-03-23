﻿using System;
namespace EmployeeManagement
{
	public class EmployeeSwitchStatement
	{
		public static void SwitchStatement()
		{
			const int IS_FULL_TIME = 1;
			const int IS_PART_TIME = 2;
			const int EMP_RATE_PER_HR = 20;

			int empHrs = 0;
			int empWage = 0;
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
			empWage = empHrs * EMP_RATE_PER_HR;
			Console.WriteLine("Emp wage : " + empWage);
		}
	}
}

