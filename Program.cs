using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program ");
            const int IS_PRESENT = 1;
            const int IS_ABSENT = 0;
            const int IS_PART_TIME = 0;
            const int IS_FULL_TIME = 1;
            int attendance = Attendance();
            int empCheck = EmpCheck();
            int dailyEmployeeWage = 0;
            
            switch(attendance)
            {
                case IS_PRESENT:
                    Console.WriteLine("The employee is present");
                    if(empCheck == IS_FULL_TIME) 
                    {
                        dailyEmployeeWage = FullTimeWage();
                    }
                    if(empCheck == IS_PART_TIME)
                    {
                        dailyEmployeeWage = PartTimeWage();
                    }
                    break;
                case IS_ABSENT:
                    Console.WriteLine("The employee is absent");
                    break;
            }
            Console.WriteLine("The daily wage of employee is "+ dailyEmployeeWage);
            
            
            
            Console.ReadKey();
        }
        static int Attendance()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
        static int EmpCheck()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
        static int FullTimeWage()
        {
            int numOfHrs = 8;
            int wagePerHour = 20;
            return numOfHrs * wagePerHour;
        }
        static int PartTimeWage()
        {
            int numOfHrs = 4;
            int wagePerHour = 20;
            return numOfHrs * wagePerHour;
        }
    }
}
