using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IAbstractIterator<T>
    {
        T First();
        T Next();
        bool IsCompleted { get; }
    }
}
