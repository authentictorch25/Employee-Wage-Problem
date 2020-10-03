﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    interface IEmpWageBuilderObject
    {
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHrs);
        public void ComputeEmpWage();
    }
}
