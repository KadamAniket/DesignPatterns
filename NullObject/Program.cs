using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new TeamRepository();

            var mclaren = repository.getTeam(2);
            Console.WriteLine(mclaren.Name);

            var ferrari = repository.getTeam(1);
            Console.WriteLine(ferrari.Name);

            var lotus = repository.getTeam(5);
            Console.WriteLine(lotus.Name);

            Console.ReadLine();
        }
    }
}
