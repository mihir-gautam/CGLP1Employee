﻿using System;

namespace EmployeeAttendanceUC
{
	class Program
	{
		static void Main(String[] args)
		{
			int IS_FULL_TIME = 1;
			Random random = new Random();
			int empCheck = random.Next(0, 2);
			if (empCheck == IS_FULL_TIME)
			{
				Console.WriteLine("Employee is Present");
			}
			else
			{
				Console.WriteLine("Employee is Absent");
			}
		}
	}
}