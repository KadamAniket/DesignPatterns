using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee maria = new Employee(100, 25000);

            Console.WriteLine("Marias joining salary:{0}",maria.CalculateSalary());

            LoyalEmployeesSalary mariaAfter5years = new LoyalEmployeesSalary(maria);
            Console.WriteLine("Marias updated salary:{0}",mariaAfter5years.CalculateSalary());

            Console.ReadLine();
        }
    }
}
