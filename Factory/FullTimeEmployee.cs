namespace Factory
{
    internal class FullTimeEmployee : IEmployeeType
    {
        public string GetEmployeeType()
        {
            return "FullTime Employee";
        }

        public int GetSalary()
        {
            return 40000;
        }

        public int GetWorkHours()
        {
            return 8;
        }
    }
}
