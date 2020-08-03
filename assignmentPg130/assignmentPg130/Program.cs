using System;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {
        int[] numArray = new int[5];
        numArray[0] = 1;
        numArray[1] = 2;
        numArray[2] = 3;
        numArray[3] = 4;
        numArray[4] = 5;

        Console.WriteLine("Please enter a numer 0 through 4:");
        int numArray1 = Convert.ToInt32(Console.ReadLine());
        if (numArray1 < 0 || numArray1 > 4)
        {
            Console.WriteLine("Oops pick a number between 0 and 4!");
        }
        else
        {
            Console.WriteLine(numArray[numArray1]);
        }
        Console.ReadLine();


        string[] stringArray = new string[6];
        stringArray[0] = "Hello";
        stringArray[1] = "my";
        stringArray[2] = "name";
        stringArray[3] = "is";
        stringArray[4] = "Jake";

        Console.WriteLine("Please enter a numer 0 through 4:");
        int stringArray1 = Convert.ToInt32(Console.ReadLine());
        if (stringArray1 < 0 || stringArray1 > 4)
        {
            Console.WriteLine("Oops pick a number between 0 and 4!");
        }
        else
        {
            Console.WriteLine(stringArray[stringArray1]);
        }
        Console.ReadLine();

        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("this");
        intList.Add("is");
        intList.Add("my");
        intList.Add("list");

        Console.WriteLine("Please enter a numer 0 through 4:");
        int intList1 = Convert.ToInt32(Console.ReadLine());

        if (intList1 < 0 || intList1 > 4)
        {
            Console.WriteLine("Oops pick a number between 0 and 4!");
        }
        else
        {
            Console.WriteLine(intList[intList1]);
        }
        Console.ReadLine();

    }
    
}

