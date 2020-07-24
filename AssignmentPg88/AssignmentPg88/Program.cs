using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a Number to times by 50");
            int product = Convert.ToInt32(Console.ReadLine());
            int Num = 50;
            int combined = product * Num;
            Console.WriteLine(combined);
            Console.ReadLine();

            Console.WriteLine("Please type a Number to add by 25");
            int total = Convert.ToInt32(Console.ReadLine());
            int Num2 = 25;
            int plus = total + Num2;
            Console.WriteLine(plus);
            Console.ReadLine();

            Console.WriteLine("Please type a Number to divide by 12.5");
            double quotient = Convert.ToInt32(Console.ReadLine());
            double Num3 = 12.5;
            double all = quotient / Num3;
            Console.WriteLine(all);
            Console.ReadLine();

            Console.WriteLine("Is your Number Greater than 50?");
            int Great = Convert.ToInt32(Console.ReadLine());
            int currentNum = 50;

            bool isGreater = Great > currentNum;
            Console.WriteLine(isGreater);
            Console.ReadLine();


            Console.WriteLine("Please type a number to find a remainder of 7");
            int remainder = Convert.ToInt32(Console.ReadLine());
            int Num5 = 7;
            int leftOver = remainder % Num5;
            Console.WriteLine(leftOver);
            Console.ReadLine();
        }
    }
}
