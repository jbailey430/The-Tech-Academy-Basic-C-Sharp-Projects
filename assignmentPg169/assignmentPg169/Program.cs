using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg169
{
    class Program
    {
        static void Main(string[] args)
        {
            First mathObj = new First();
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 2;
            mathObj.divide(x);

            mathObj.Para(x, out y);
            Console.WriteLine(y);
            Console.ReadLine();

            mathObj.Para(x);

            int z = Second.Plus(10);
            Console.WriteLine(z);
            Console.ReadLine();
            
        }
    }
}
