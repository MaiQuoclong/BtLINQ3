using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtLINQ3
{
    public class Position
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Position(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
