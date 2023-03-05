using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class CompanyA : ISalaryBonus
    {
        public int CalculateSalaryBonus(Employee employees)
        {
            // DO some logic

            return employees.Salary + 2000;
        }
    }
}
