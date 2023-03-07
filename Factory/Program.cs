using System;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = EmployeeFactory.GetEmployee("FullTime Employee");

            Console.WriteLine("Type:{0}", employee.GetEmployeeType());
            Console.WriteLine("Salary:{0}", employee.GetSalary());
            Console.WriteLine("Working Hours:{0}", employee.GetWorkHours());

            Console.ReadLine();
        }
    }
}
