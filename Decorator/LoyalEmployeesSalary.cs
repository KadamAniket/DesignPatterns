using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class LoyalEmployeesSalary : EmployeeSalaryDecorator
    {

        public LoyalEmployeesSalary(Employee emp):base(emp)
        {

        }

        public override int CalculateSalary()
        {
            return base.CalculateSalary() + AddBonus();
        }

        private int AddBonus()
        {
            return 10000;
        }
    }
}
