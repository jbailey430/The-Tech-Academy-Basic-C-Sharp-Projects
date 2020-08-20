using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg165
{
    class Program
    {
        static void Main(string[] args)
        {
            Para mathObj = new Para();
            Console.WriteLine("Enter a number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number if you'd like: ");
            string userInput2 = Console.ReadLine();
            int result1;
            if (userInput2 == "")
            {
                result1 = mathObj.Plus(userInput1);
            }
            else
            {
                int Value = Convert.ToInt32(userInput2);
                result1 = mathObj.Plus(userInput1, Value);
            }

            Console.WriteLine(result1);
            Console.ReadLine();
        }
    }
}
