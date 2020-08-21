using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg203
{
    class Program
    {
         public static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee { empID = 1, Fname = "Joe", Lname = "Smith"});
            employee.Add(new Employee { empID = 3, Fname = "Jake", Lname = "Bailey" });
            employee.Add(new Employee { empID = 5, Fname = "Britt", Lname = "Scott" });
            employee.Add(new Employee { empID = 7, Fname = "Tyler", Lname = "Reed" });
            employee.Add(new Employee { empID = 9, Fname = "Joe", Lname = "Rogers" });
            employee.Add(new Employee { empID = 12, Fname = "Jess", Lname = "Dom" });
            employee.Add(new Employee { empID = 14, Fname = "Kristen", Lname = "Marie" });
            employee.Add(new Employee { empID = 16, Fname = "Robert", Lname = "Arnold" });
            employee.Add(new Employee { empID = 18, Fname = "Joe", Lname = "Somebody" });
            employee.Add(new Employee { empID = 20, Fname = "Kelly", Lname = "Smith" });

            foreach (Employee name in employee)
            {
                if (name.Fname == "Joe")
                {
                    Console.WriteLine("ID:" + name.empID + " " + "Name:" + name.Fname + " " + name.Lname);
                }
            }
            Console.ReadLine();

            List<Employee> newList = employee.Where(x => x.Fname == "Joe").ToList();

            foreach (Employee name in newList)
            {
                Console.WriteLine(name.empID + " " + name.Fname + " " + name.Lname);
            }
            Console.ReadLine();

            List<Employee> idList = employee.Where(x => x.empID > 5).ToList();
            
            foreach (Employee id in idList)
            {
                Console.WriteLine(id.empID + " " + id.Fname + " " + id.Lname);
            }
            Console.ReadLine();
        }
    }   
}
