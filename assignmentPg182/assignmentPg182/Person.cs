using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg182
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            var FullName = firstName + " " + lastName;
            Console.WriteLine("Name: " + FullName);
            Console.ReadLine();
        }
    }
}
