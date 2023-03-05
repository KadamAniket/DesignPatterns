using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    sealed class ThreadSafeSingleton
    {
        private static readonly Lazy<ThreadSafeSingleton> obj = new Lazy<ThreadSafeSingleton>(()=> new ThreadSafeSingleton());
        public Guid Id { get; set; }
        private ThreadSafeSingleton()
        {
            Id = Guid.NewGuid();
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                return obj.Value;
            }
        }

    }
}
