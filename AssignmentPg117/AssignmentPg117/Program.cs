using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg117
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int pack = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensions = width + (height + length);
            int totalMultiply = width * (height * length);
            int totalWeight = totalMultiply * pack;
            int total = totalWeight / 100;

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            Console.ReadLine();

            Console.WriteLine("Your estimated total for shipping this package is: $"+ total + ".00 Thank You");
            Console.ReadLine();
        }
    }
}
