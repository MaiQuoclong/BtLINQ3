using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtLINQ3
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Position Position { get; set; }
        public Department Department { get; set; }

        public Employee(string name, int age, Position position, Department department)
        {
            Name = name;
            Age = age;
            Position = position;
            Department = department;
        }
    }
}
