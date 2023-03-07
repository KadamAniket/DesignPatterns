namespace FactoryMethod
{
    internal class ContractEmployeeFactory : EmployeeFactory
    {
        protected override IEmployeeType AddEmployee()
        {
            return new ContractEmployee();
        }
    }
}
