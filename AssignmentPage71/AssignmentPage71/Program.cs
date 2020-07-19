using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage71
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string name = "";
            Console.WriteLine(name);
            Console.ReadLine();


            Console.WriteLine("What course are you on?");
            string course = "";
            Console.WriteLine(course);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            int pgNum = 0;
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool Yes = true;
            bool No = false;
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string comment = "";
            Console.WriteLine(comment);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = "";
            Console.ReadLine();


            Console.WriteLine("How many hours did you study today?");
            byte hours = 0;
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();






        }
    }
}
