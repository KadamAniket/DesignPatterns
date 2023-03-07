namespace AbstractFactory
{
    internal interface ICompanyFactory
    {
        IEmployeeType CreateEmployee(string empType);
    }




}
