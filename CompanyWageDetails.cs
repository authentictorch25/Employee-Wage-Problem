using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class CompanyWageDetails
    {
        public string company;
        public int empRatePerHour, numOfWorkingDays, maxWorkingHrs;
        public int totalEmpWage;

        public CompanyWageDetails(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
            this.totalEmpWage = 0;
        }

        public void GetDetails()
        {
            Console.WriteLine("                                                ");
            Console.WriteLine("Total Employee Wage for " + company + " Employee is: " + totalEmpWage);
            Console.WriteLine("                                              \n");
        }
    }
}
