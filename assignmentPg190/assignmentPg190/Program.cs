using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg190
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("Dog");
            employee.Things.Add("Car");
            employee.Things.Add("House");

            foreach (string element in employee.Things)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>();
            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(3);

            foreach (int element in employee2.Things)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();


        }
    }
}
