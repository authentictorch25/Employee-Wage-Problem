using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program ");
            const int IS_PRESENT = 1;
            int attendance = Attendance();
            if (attendance == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

            int dailyEmployeeWage = 0;
            if(attendance == IS_PRESENT)
            {
                dailyEmployeeWage = DailyEmployeeWage();
            }
            Console.WriteLine("The daily employee wage : " + dailyEmployeeWage);
            Console.ReadKey();
        }
        static int Attendance()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
        static int DailyEmployeeWage()
        {
            int numOfHrs = 8;
            int wagePerHour = 20;
            return numOfHrs * wagePerHour;
        }
    }
}
