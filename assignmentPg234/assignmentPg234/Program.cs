using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg234
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age?");
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age <= 0)
                {
                    throw new MyOwnException();
                }
                int Year = DateTime.Now.Year - Age;
                Console.WriteLine("You were born in " + Year);
                Console.ReadLine();
            }
            catch (MyOwnException)
            {
                Console.WriteLine("Please enter digits greater than 0. Thank You ");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wront please try again.");
                Console.ReadLine();
                return;
            }
        
            
        }
    }
}
