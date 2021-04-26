using System;
using System.Text;

namespace Prototype
{
    public class Person : ICloneable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age  { get; set; }

        public Person(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public string showInfo()
        {
            return string.Format("Id:{0}  Name:{1}  Age:{2}", Id, Name, Age);
        }

        public object Clone()
        {
            var clonePerson = new Person(this.Name);
            clonePerson.Age = this.Age;

            return clonePerson;
        }
    }
}
