using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var david = new Employee(1, "David", 25000, 40);
            var empSal = new EmployeeSalary();

            var totalSalary = empSal.calculateSalary(david);

            Console.WriteLine("Total Salary for David:{0}",totalSalary);

            Console.ReadLine();
        }
    }
}
