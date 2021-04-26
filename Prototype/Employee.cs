using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Department
    {
        public string Name { get; set; }
        public Department(string name)
        {
            Name = name;
        }

    }

    public class Employee : ICloneable
    {
        public Guid EmpId { get; set; }
        public string Name { get; set; }

        public Department Dept { get; set; }

        public Employee(string name,string deptName)
        {
            EmpId = Guid.NewGuid();
            Name = name;
            Dept = new Department(deptName);
        }

        public string showInfo()
        {
            return string.Format("Id:{0}  Name:{1}  Age:{2}", EmpId, Name, Dept.Name);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            var employee = new Employee(Name,Dept.Name);
            
            return employee;
        }
    }
}
