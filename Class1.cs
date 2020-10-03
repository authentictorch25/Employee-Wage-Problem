using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmpWageBuilderObject
    {
        private string company;
        private int empRatePerHour, numOfWorkingDays, maxWorkingHrs;
        private int totalEmpWage;
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
            this.totalEmpWage = 0;
        }
        const int IS_ABSENT = 0;
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        
        public void CalculateEmpWage()
        {
            Console.WriteLine("Wage Calculation for Employee of " + this.company);
            Random random = new Random();
            int empHours = 0, totalWorkingHrsCumulative = 0;
            for (int currentDay = 1; currentDay <= numOfWorkingDays && totalWorkingHrsCumulative <= maxWorkingHrs; currentDay++)

            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_ABSENT:
                        empHours = 0;
                        break;
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    default:
                        break;
                }
                if (totalWorkingHrsCumulative + empHours > this.maxWorkingHrs)
                    empHours = 0;
                totalWorkingHrsCumulative += empHours;
                Console.WriteLine("Day " + (currentDay) + " Employee Hours " + empHours);

            }
            Console.WriteLine("Total Employee Hours " + totalWorkingHrsCumulative);
            totalEmpWage = totalWorkingHrsCumulative * this.empRatePerHour;
            Console.WriteLine("Total Employee Wage " + totalEmpWage + "\n"+ "\n");

        }
        public void GetDetails()
        {
            Console.WriteLine("                                  ");
            Console.WriteLine("Total Employee Wage for " + this.company + " Employee is: " + totalEmpWage);
            Console.WriteLine("                                 \n");
        }
    }
 }
    


