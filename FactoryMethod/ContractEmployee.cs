namespace FactoryMethod
{
    internal class ContractEmployee : IEmployeeType
    {
        public string GetEmployeeType()
        {
            return "Contract Employee";
        }

        public int GetSalary()
        {
            return 45000;
        }

        public int GetWorkHours()
        {
            return 10;
        }
    }
}
