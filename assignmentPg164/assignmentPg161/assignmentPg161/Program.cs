using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg161
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Method method = new Method();
            int Sum = 12;
            int results = method.Addition(userInput, Sum);
            Console.WriteLine(results);

            int Total = 10;
            int results1 = method.Multiply(userInput, Total);
            Console.WriteLine(results1);

            int sumTotal = 2;
            int results2 = method.Divide(userInput, sumTotal);
            Console.WriteLine(results2);

            Console.ReadLine();
        }
    }
}
