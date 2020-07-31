using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg125
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jacob";
            string lname = "Bailey";
            string animal = "dog";
            string total = "Hello, " + name + " " + lname + ", We didn't realize your favorite animal was a " + animal + " that is awesome!";

            
            Console.WriteLine(total);
            Console.ReadLine();


            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("\t My name is Jacob. My favorite animal is a dog. \n I have a dog and her name is Chloe. \n We go on walks around the neighborhood every night. \n Some days we go on hikes and even to the beach. ");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
