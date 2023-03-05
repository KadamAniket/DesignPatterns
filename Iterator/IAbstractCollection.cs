using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IAbstractCollection<T>
    {
        public int Count { get; }
        IAbstractIterator<T> CreateIterator();

        void AddItem(T item);

        T GetItem(int indexPosition);
    }
}
