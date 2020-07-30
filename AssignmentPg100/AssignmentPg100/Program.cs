using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool Dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int Speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");

            bool totalBool = (Age > 15 && (Dui == false  && Speed <= 3 ));
            Console.WriteLine(totalBool);
            Console.ReadLine();
        }
    }
}
