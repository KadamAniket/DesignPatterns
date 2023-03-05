using System;
using System.Threading;
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


            // MultiThreading case
            //Thread t1 = new Thread(new ThreadStart(() => { Console.WriteLine(Singleton.Instance.Id); }));
            //Thread t2 = new Thread(new ThreadStart(() => { Console.WriteLine(Singleton.Instance.Id); }));

            //t1.Start();
            //t2.Start();

            //t1.Join();
            //t2.Join();

            // OR

            //Parallel.Invoke(
            //    () => CreateInstance(),
            //    () => CreateInstance()
            //    );

            callThreadSafeSingleton();


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
