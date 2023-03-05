using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            EmployeeConcreteCollection collection = new EmployeeConcreteCollection();
            collection.AddItem(new Employee("Anurag", 100));
            collection.AddItem(new Employee("Pranaya", 101));
            collection.AddItem(new Employee("Santosh", 102));
            collection.AddItem(new Employee("Priyanka", 103));
            collection.AddItem(new Employee("Abinash", 104));
            collection.AddItem(new Employee("Preety", 105));

            // Create iterator
            IAbstractIterator<Employee> iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.Id} & Name : {emp.Name}");
            }


            Console.ReadLine();
        }
    }
}
