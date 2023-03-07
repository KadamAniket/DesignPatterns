using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICompanyFactory companyFactory = new CompanyABCFactory();

            var employee = companyFactory.CreateEmployee("FullTime");

            Console.WriteLine("Type:{0}", employee.GetEmployeeType());
            Console.WriteLine("Salary:{0}", employee.GetSalary());
            Console.WriteLine("Working Hours:{0}", employee.GetWorkHours());

            Console.ReadLine();
        }
    }
}
