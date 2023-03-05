using System;

namespace Singleton
{
    sealed class Singleton
    {
        private static Singleton obj;
        public Guid Id { get; set; }
        private Singleton()
        {
            Id = Guid.NewGuid();
        }

        public static Singleton Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new Singleton();
                }

                return obj;
            }
        }

    }
}
