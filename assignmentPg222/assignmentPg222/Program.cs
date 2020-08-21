using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignmentPg222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = dt1.AddHours(num);

            using (StreamWriter file = new StreamWriter(@"C:\Users\JAKEBAILEY30\Desktop\The Tech Academy Basic C-Sharp Projects\assignmentPg222\assignment.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(dt2);
            }
            Console.WriteLine("The current time and Date is " + DateTime.Now + " in " + num + " hours it will be " + dt2);
            Console.ReadLine();
        }
    }
}
