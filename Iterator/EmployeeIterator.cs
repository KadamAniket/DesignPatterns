using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class EmployeeIterator : IAbstractIterator<Employee>
    {
        private EmployeeConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        
        public EmployeeIterator(EmployeeConcreteCollection collection)
        {
            this.collection = collection;
        }
        
        
        public Employee First()
        {
            current = 0;
            return collection.GetItem(current);
        }

        public Employee Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetItem(current);
            }
            else
            {
                return null;
            }
        }

        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}
