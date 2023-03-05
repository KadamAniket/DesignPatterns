using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class EmployeeSalaryDecorator : IEmployee
    {
        private Employee Emp { get; set; }

        public EmployeeSalaryDecorator(Employee employee)
        {
            Emp = employee;
        }
        public virtual int CalculateSalary()
        {
            return Emp.CalculateSalary();
        }
    }
}
