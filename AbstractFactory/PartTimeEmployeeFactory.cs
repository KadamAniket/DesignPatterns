namespace AbstractFactory
{
    internal class PartTimeEmployeeFactory : EmployeeFactory
    {
        protected override IEmployeeType AddEmployee()
        {
            return new PartTimeEmployee();
        }
    }
}
