namespace AbstractFactory
{
    class CompanyXYZFactory : ICompanyFactory
    {
        public IEmployeeType CreateEmployee(string empType)
        {
            switch (empType)
            {
                case "FullTime":
                    return new FullTimeEmployeeFactory().CreateEmployee();

                case "PartTime":
                    return new PartTimeEmployeeFactory().CreateEmployee();

                case "Contract":
                    return new ContractEmployeeFactory().CreateEmployee();

                default:
                    return null;
            }
        }
    }
}
