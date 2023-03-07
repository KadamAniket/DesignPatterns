using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            EmployeeConcreteCollection collection = new EmployeeConcreteCollection();
            collection.AddItem(new Employee("Aniket", 100));
            collection.AddItem(new Employee("Rajiv", 101));
            collection.AddItem(new Employee("Pradeep", 102));


            // Create iterator
            IAbstractIterator<Employee> iterator = collection.CreateIterator();


            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.Id} & Name : {emp.Name}");
            }


            Console.ReadLine();
        }
    }
}
