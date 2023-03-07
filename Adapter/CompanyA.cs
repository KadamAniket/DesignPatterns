namespace Adapter
{
    class CompanyA : ISalaryBonus
    {

        public int CalculateSalaryBonus(Employee employee)
        {
            // DO some logic

            return employee.Salary + 2000;
        }
    }
}
