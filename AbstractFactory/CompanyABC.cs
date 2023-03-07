namespace AbstractFactory
{
    class CompanyABCFactory : ICompanyFactory
    {
        public IEmployeeType CreateEmployee(string empType)
        {
            switch (empType)
            {
                case "FullTime":
                    return new FullTimeEmployeeFactory().CreateEmployee();

                case "PartTime":
                    return new PartTimeEmployeeFactory().CreateEmployee();

                default:
                    return null;
            }
        }
    }
}
