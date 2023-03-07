using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientWithCompanyB();


            Console.ReadLine();
        }

        private static void ClientWithCompanyA()
        {
            Employee emp = new Employee(1, "David", "Senior Developer", 2500);

            CompanyA a = new CompanyA();
            Client abc = new Client(a);

            Console.WriteLine("Employee Bonus Salary:{0}", abc.CalculateSalaryBonus(emp));
        }

        private static void ClientWithCompanyB()
        {
            Employee emp = new Employee(1, "David", "Senior Developer", 2500);

            CompanyB b = new CompanyB();
            Adapter adapter = new Adapter(b);
            Client abc = new Client(adapter);

            Console.WriteLine("Employee Bonus Salary:{0}", abc.CalculateSalaryBonus(emp));
        }
    }
}
