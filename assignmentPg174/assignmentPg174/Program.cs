using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg174
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            Employee employee2 = new Employee();
            employee2.ID = 1;
            employee2.FirstName = "Joe";
            employee2.LastName = "Snow";

            if (employee1 == employee2)
            {
                Console.WriteLine("Employee ID is equal.");
            }
            else 
            {
                Console.WriteLine("Employee ID is not equal");
            }
            Console.ReadLine();
        }
    }
}
