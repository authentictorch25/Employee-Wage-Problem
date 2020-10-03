using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program ");
            const int IS_PRESENT = 1;
            const int IS_PART_TIME = 0;
            const int IS_FULL_TIME = 1;
            int attendance = Attendance();
            int empCheck = EmpCheck();
            int dailyEmployeeWage = 0;
            int partTimeWage = 0;

           
            if (empCheck == IS_FULL_TIME && attendance == IS_PRESENT)
            {
                dailyEmployeeWage = FullTimeWage();
                Console.WriteLine("The employee is present");
                Console.WriteLine("The daily employee wage : " + dailyEmployeeWage);

            }
            else if (empCheck == IS_PART_TIME && attendance == IS_PRESENT)
            {
                dailyEmployeeWage = PartTimeWage();
                Console.WriteLine("The employee is present");
                Console.WriteLine("The daily employee wage : " + dailyEmployeeWage);
            }

            else
            {
                Console.WriteLine("The employee is absent");
                Console.WriteLine("The daily employee wage : " + dailyEmployeeWage);
            }

            
            
            
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
