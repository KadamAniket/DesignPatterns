using Strategy.Models;
using Strategy.Taxes;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order(Guid.NewGuid(), 4500);
            int choice;
            Invoice invoice;
            do
            {
                Console.WriteLine("-----------TAX SIMULATOR---------");
                // Console.WriteLine("Enter amount");
                Console.WriteLine("1. India");
                Console.WriteLine("2. Finland");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        invoice = new Invoice(o1, new TaxForIndia());
                        Console.WriteLine("Total Amount={0}", invoice.calculate());
                        break;

                    case 2:
                        invoice = new Invoice(o1, new TaxForFinland());
                        Console.WriteLine("Total Amount={0}", invoice.calculate());
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                
            } while (choice != 0);
        }
    }
}
