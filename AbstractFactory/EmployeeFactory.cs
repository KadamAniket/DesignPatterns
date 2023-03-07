namespace AbstractFactory
{
    internal abstract class EmployeeFactory
    {
        protected abstract IEmployeeType AddEmployee();

        public IEmployeeType CreateEmployee()
        {
            return AddEmployee();
        }
    }
}
