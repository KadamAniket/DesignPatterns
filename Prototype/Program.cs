using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var aniket = new Person("Aniket");
            aniket.Age = 30;

            var ashwini = (Person)aniket.Clone();
            ashwini.Name = "Ashwini";
            ashwini.Age = 27;

            Console.WriteLine(aniket.showInfo());
            Console.WriteLine(ashwini.showInfo());


            // Shallow Copy
            var empAniket = new Employee("Aniket", "Healthcare");

            var empAshwini = (Employee)empAniket.Clone();
            empAshwini.Name = "Ashwini";

            empAniket.Dept.Name = "Medicine";

            Console.WriteLine("----------Shallow Copy--------");
            Console.WriteLine(empAniket.showInfo());
            Console.WriteLine(empAshwini.showInfo());


            // Deep Copy
            var empArush = new Employee("Arush", "Training");
            var empAnoop = empArush.DeepCopy();
            empAnoop.Name = "Anoop";

            empArush.Dept.Name = "IT Support";
            Console.WriteLine("----------Deep Copy--------");
            Console.WriteLine(empArush.showInfo());
            Console.WriteLine(empAnoop.showInfo());
        }
    }
}
