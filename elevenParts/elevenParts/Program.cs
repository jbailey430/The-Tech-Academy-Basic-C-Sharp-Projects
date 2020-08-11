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
                break;
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
                break;
            }
        }
        Console.ReadLine();



        List<string> same = new List<string>() { "fish", "sea", "boats", "sea", "pirates", "sharks" };
        List<string> duplicate = new List<string>() {};


        foreach (string i in same)
        {
            
            foreach (string j in duplicate)
            {
                if (i == j )
                {
                    Console.WriteLine("The name " + i + " is a duplicate.");
                }

            }
            Console.WriteLine("Name is not on the list. ");
            duplicate.Add(i);
        }
        Console.ReadLine();
    }
        
    
}

