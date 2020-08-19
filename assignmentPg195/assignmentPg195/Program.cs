using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg195
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current Day of the Week: ");
            string currentDay = Console.ReadLine();

            WeekDay day;
            try
            {
                day = (WeekDay)Enum.Parse(typeof(WeekDay), currentDay);
                Console.WriteLine("You entered: " + day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);

                // fallback value
                day = WeekDay.None;

                Console.ReadLine();
            }

        }
        public enum WeekDay
        { 
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6,
            None = 7
        }
    }
}
