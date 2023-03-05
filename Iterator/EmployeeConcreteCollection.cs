using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class EmployeeConcreteCollection : IAbstractCollection<Employee>
    {
        private List<Employee> listEmployees = new List<Employee>();
     
        public int Count
        {
            get { return listEmployees.Count; }
        }
        
        public void AddItem(Employee employee)
        {
            listEmployees.Add(employee);
        }
        
        public Employee GetItem(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }

        public IAbstractIterator<Employee> CreateIterator()
        {
            return new EmployeeIterator(this);
        }
    }

}
