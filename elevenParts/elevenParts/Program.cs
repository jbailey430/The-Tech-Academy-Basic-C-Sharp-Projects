using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = new string[5];
        stringArray[0] = "1. ";
        stringArray[1] = "2. ";
        stringArray[2] = "3. ";
        stringArray[3] = "4. ";
        stringArray[4] = "5. ";

        Console.WriteLine("Please add your name to the array:");
        string names = Console.ReadLine();

        foreach (string i in stringArray)
        {
            Console.WriteLine(i + " " + names);
        }

        // for loop for the infinite loop//
        // fixed now//
        // <= comparison thats used//

        for (int i = 0; i <= 50; i++)
        {
            Console.WriteLine(i + " " + names);
        }
        Console.ReadLine();


        List<string> unique = new List<string>() { "apple", "dog", "ocean", "John" };

        Console.WriteLine("Type a word from the list:");
        string userInput = Console.ReadLine();

        foreach (string j in unique)
        {
            if (userInput == j)
            {
                Console.WriteLine("A match for " + userInput + " was found at index " + unique.IndexOf(userInput));
                break;
            }
            else
            {
                Console.WriteLine("Oops, " + userInput + " is not in the list:");
            }
        }
        Console.ReadLine();


        List<string> identical = new List<string>() { "fish", "sea", "boats", "sea", "pirates", "sharks" };

        Console.WriteLine("Type a word from the list:");
        string userText = Console.ReadLine();

        for (int i = 0; i < identical.Count; i++)
        {
            if (identical[i] == userText)
            {
                Console.WriteLine(i);
                break;
            }
            else
            {
                Console.WriteLine("Oops, " + userText + " is not in the list:");
            }
        }
        Console.ReadLine();



        List<string> same = new List<string>() { "dog", "cat", "dog", "bunny", "dog", "cat", "bunny" };

        int m = 0, n = 0, p = 0;

        foreach (string i in same)
        {
            if (i == "dog")
                m++;
            else if (i == "cat")
                n++;
            else
                p++;
        }
        Console.WriteLine("Number of 'dog' = {0}", m);
        Console.WriteLine("Number of 'cat' = {0}", n);
        Console.WriteLine("Number of 'bunny' = {0}", p);
        Console.ReadLine();
    }

}

