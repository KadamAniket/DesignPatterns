using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class EmployeeSalary
    {
        public double calculateSalary(Employee emp)
        {
            var allowance = new EmployeeAllowance();
            var bonusTime = new EmployeeBonus();
            var extraTime = new EmployeeExtraTime();


            return emp.Salary
                + allowance.CalculateEmployeeAllowance(emp.Salary) 
                + bonusTime.calculateEmployeeBonus(emp.HoursWorked)
                + extraTime.CalculateSalaryForExtraTime(emp.HoursWorked);
        }
    }
}
