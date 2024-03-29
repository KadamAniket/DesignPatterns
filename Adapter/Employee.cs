﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public Employee(int id, string name, string designation, int salary)
        {
            ID = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }
    }
}
