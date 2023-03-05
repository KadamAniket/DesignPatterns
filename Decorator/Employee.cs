using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Employee : IEmployee
    {
        private int Id { get; set; }
        private int Salary { get; set; }
        public Employee(int id, int salary)
        {
            Id = id;
            Salary = salary;
        }

        public int CalculateSalary()
        {
            return Salary;
        }
    }
}
