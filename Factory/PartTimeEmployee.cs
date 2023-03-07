namespace Factory
{
    internal class PartTimeEmployee : IEmployeeType
    {
        public string GetEmployeeType()
        {
            return "PartTime Employee";
        }

        public int GetSalary()
        {
            return 15000;
        }

        public int GetWorkHours()
        {
            return 4;
        }
    }
}
