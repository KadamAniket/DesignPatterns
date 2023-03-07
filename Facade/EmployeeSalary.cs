namespace Facade
{
    class EmployeeSalary
    {
        public double calculateSalary(Employee emp)
        {
            var allowance = new EmployeeAllowance();
            var performanaceBonus = new EmployeeBonus();
            var extraTime = new EmployeeExtraTime();


            return emp.Salary
                + allowance.CalculateEmployeeAllowance(emp.Salary)
                + performanaceBonus.calculateEmployeeBonus(emp.HoursWorked)
                + extraTime.CalculateSalaryForExtraTime(emp.HoursWorked);
        }
    }
}
