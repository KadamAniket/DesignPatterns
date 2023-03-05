using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class EmployeeAllowance
    {
        public double CalculateEmployeeAllowance(double empSalary)
        {
            return empSalary * 0.5;
        }
    }
}
