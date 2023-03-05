using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : ISalaryBonus
    {
        private readonly CompanyB _compB;
        public Adapter(CompanyB compB)
        {
            _compB = compB;
        }

        public int CalculateSalaryBonus(Employee employees)
        {
            return _compB.CalculateEmployeeSalaryBonus(employees.Salary);
        }
    }
}
