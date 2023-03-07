using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main()
        {

            // Simple case

            //var instance1 = Singleton.Instance;
            //var instance2 = Singleton.Instance;
            //Console.WriteLine(instance1.Id);
            //Console.WriteLine(instance2.Id);


            //Parallel.Invoke(
            //() => CreateInstance(),
            //    () => CreateInstance()
            //    );


            Parallel.Invoke(
            () => createThreadSafeSingletonInstance(),
                () => createThreadSafeSingletonInstance()
             );




            Console.ReadLine();

        }

        private static void CreateInstance()
        {
            var instace = Singleton.Instance;
            Console.WriteLine(instace.Id);
        }

        private static void callThreadSafeSingleton()
        {
            Parallel.Invoke(
                () => createThreadSafeSingletonInstance(),
                () => createThreadSafeSingletonInstance()
                );
        }

        private static void createThreadSafeSingletonInstance()
        {
            var instance = ThreadSafeSingleton.Instance;
            Console.WriteLine(instance.Id);
        }
    }
}
