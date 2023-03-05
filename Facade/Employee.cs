using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public int HoursWorked { get; set; }

        public Employee(int id, string name,double salary,int hoursWorked)
        {
            Id = id;
            Name = name;
            Salary = salary;
            HoursWorked = hoursWorked;
        }
    }
}
