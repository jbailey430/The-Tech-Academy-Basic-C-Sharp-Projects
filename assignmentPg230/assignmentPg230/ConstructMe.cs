using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg230
{
    class ConstructMe
    {
        public string Name { get; set; }
        public string School { get; set; }

        public ConstructMe(string name) : this(name, "Jake") { }
        public ConstructMe(string name, string school)
        {
           Name = name;
           School = school;
        }
    }
}
