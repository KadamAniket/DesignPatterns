using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class CompanyB
    {
        public int CalculateEmployeeSalaryBonus(int employeeSalary)
        {
            // DO some logic

            return employeeSalary + 25000;
        }
    }
}
