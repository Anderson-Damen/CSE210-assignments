using System;
using System.Diagnostics.CodeAnalysis;

class Grocery
{
    List<strint> groceries = new List<string>();
    string userInput = "";

    while (userInput != "done")
    {
        Console.WriteLine("What would you like to add to your grocery list?");
        userInput = Console.ReadLine();
        groceries.Add(userInput);
    }

    static void DisplayList(List<string> groceries)
    {
        foreach (string item in groceries)
        {
            Console.WriteLine(item);
        }
    }
}