using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new PartTimeEmployeeFactory().CreateEmployee();

            Console.WriteLine("Type:{0}", employee.GetEmployeeType());
            Console.WriteLine("Salary:{0}", employee.GetSalary());
            Console.WriteLine("Working Hours:{0}", employee.GetWorkHours());

            Console.ReadLine();
        }
    }
}
