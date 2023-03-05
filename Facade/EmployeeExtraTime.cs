using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class EmployeeExtraTime
    {
        public int CalculateSalaryForExtraTime(int workingHours)
        {
            int extraHoursWorked = workingHours - 40;
            if (extraHoursWorked > 0)
            {
                return extraHoursWorked * 1000;
            }

            return 0;
        }
    }
}
