using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtLINQ3
{
    public class Department
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Department(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
