using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientWithCompanyA();
            ClientWithCompanyB();
        }

        private static void ClientWithCompanyA()
        {
            Employee emp = new Employee(1, "David", "Senior Developer", 2500);

            CompanyA a = new CompanyA();
            Client abc = new Client(a);

            Console.WriteLine(abc.CalculateSalaryBonus(emp));
        }

        private static void ClientWithCompanyB()
        {
            Employee emp = new Employee(1, "David", "Senior Developer", 2500);

            CompanyB b = new CompanyB();
            Adapter adapter = new Adapter(b);
            Client abc = new Client(adapter);

            Console.WriteLine(abc.CalculateSalaryBonus(emp));
        }
    }
}
