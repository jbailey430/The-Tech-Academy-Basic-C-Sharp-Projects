using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignmentPg219
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\JAKEBAILEY30\Desktop\The Tech Academy Basic C-Sharp Projects\assignmentPg219\assignment.txt", true))
            {
                file.WriteLine(num);
            }
            Console.WriteLine("You chose: " + num + " as your number");
            Console.ReadLine();
        }
    }
}
