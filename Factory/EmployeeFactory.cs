namespace Factory
{
    internal class EmployeeFactory
    {
        public static IEmployeeType GetEmployee(string employeeType)
        {
            switch (employeeType)
            {
                case "FullTime Employee":
                    return new FullTimeEmployee();


                case "Contract Employee":
                    return new ContractEmployee();


                default:
                    return new PartTimeEmployee();
            }
        }
    }
}
