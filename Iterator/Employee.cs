using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
