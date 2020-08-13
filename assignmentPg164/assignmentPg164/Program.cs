using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg164
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathObj = new Math();
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int result1 = mathObj.plus(userInput);
            Console.WriteLine(result1);
            Console.ReadLine();

            Console.WriteLine("Enter a decimal: ");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            int result2 = mathObj.multiply(input);
            Console.WriteLine(result2);
            Console.ReadLine();



            Console.WriteLine("Type out a whole number: ");
            string aValue = Console.ReadLine();
            int result3 = mathObj.divide(aValue);
            Console.WriteLine(result3);
            Console.ReadLine();

        }

    } 
}
