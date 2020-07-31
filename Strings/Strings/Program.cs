using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jessie";
            //string qoute = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrfalse = name.Contains("s");
            //trueOrfalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(trueOrfalse);
            //Console.ReadLine();


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
