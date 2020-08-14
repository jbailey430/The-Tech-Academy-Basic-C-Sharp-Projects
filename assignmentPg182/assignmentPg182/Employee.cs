using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg182
{
    public class Employee : Person, IQuittable
    {
        public void Quit(Employee employee)
        {
            var FullName = firstName + " " + lastName;
            Console.WriteLine("Employee " + FullName + " has quit!");
        }
    }
}
