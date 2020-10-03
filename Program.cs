using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program ");

            ComputeWage("Dmart", 20, 20, 100 );

            Console.WriteLine("                                             ");

            ComputeWage("Reliance", 15, 25, 120);
            Console.ReadKey();
        }

        static void ComputeWage(string company, int wagePerHour, int numOfWorkingDays, int maxNoOfHrs)

         { 
            
            const int IS_PRESENT = 1;
            const int IS_ABSENT = 0;
            const int IS_PART_TIME = 0;
            const int IS_FULL_TIME = 1;
            


            int workingDays = 0;
            int dailyEmployeeWage = 0;
            int totalWage = 0;
            int workingHrs = 0;


            Console.WriteLine("This computation is for {0}", company);
            while(workingHrs <= maxNoOfHrs && workingDays <= numOfWorkingDays )
            {
                int attendance = Attendance();
                int empCheck = EmpCheck();
                switch (attendance)
                {
                    case IS_PRESENT:
                       
                        switch(empCheck)
                        {
                             
                        case IS_FULL_TIME:
                         Console.WriteLine("The employee is present, full time on day {0}", workingDays);
                         dailyEmployeeWage = wagePerHour*8;
                          workingDays++;
                                break;


                            case IS_PART_TIME:
                        
                            dailyEmployeeWage = wagePerHour*4;
                            Console.WriteLine("The employee is present, part time on day {0}", workingDays);
                            workingDays++;
                                break;
                            default:
                                break;
                        }
                        break;
                    case IS_ABSENT:
                       
                       // Console.WriteLine("The employee is absent");
                        break;
                    default:
                        break;
                }

                
                totalWage = totalWage + dailyEmployeeWage;

            }
            Console.WriteLine("The total wage of employee for the month is "+ totalWage);
            
            
            
            
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
       
    }
}
