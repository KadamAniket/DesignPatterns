namespace AbstractFactory
{
    internal class FullTimeEmployeeFactory : EmployeeFactory
    {
        protected override IEmployeeType AddEmployee()
        {
            return new FullTimeEmployee();
        }
    }
}
