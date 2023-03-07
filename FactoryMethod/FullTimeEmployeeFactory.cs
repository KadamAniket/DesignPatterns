namespace FactoryMethod
{
    internal class FullTimeEmployeeFactory : EmployeeFactory
    {
        protected override IEmployeeType AddEmployee()
        {
            return new FullTimeEmployee();
        }
    }
}
