using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg174
{
    public class Person
    {
        public List<string> Names { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        public void SayName()
        {
            var FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + FullName);
            Console.ReadLine();
        }
    }
}
