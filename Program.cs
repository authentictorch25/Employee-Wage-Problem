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
            Console.ReadKey();
        }
        static int Attendance()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}
