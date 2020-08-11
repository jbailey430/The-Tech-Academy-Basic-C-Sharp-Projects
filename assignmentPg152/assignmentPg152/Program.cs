using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg152
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> divide = new List<int>() { 12, 30, 10, 100 };
                Console.WriteLine("Input a number to divide by the list");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int number in divide)
                {
                    Console.WriteLine(number / userInput);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by Zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        
    }
}
