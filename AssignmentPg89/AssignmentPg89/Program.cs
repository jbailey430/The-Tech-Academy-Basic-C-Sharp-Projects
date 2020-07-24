using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int Hourly = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hours Worked per week?");
            int Hours = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int Hourly1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hours Worked per week?");
            int Hours1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Annual salary of Person 1:");
            long salary = Convert.ToInt64(Console.ReadLine());
            

            Console.WriteLine("Annual salary of Person 2:");
            long salary1 = Convert.ToInt64(Console.ReadLine());
            

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            
            bool annual = salary > salary1;
            Console.WriteLine(annual);
            Console.ReadLine();


        }
    }
}
