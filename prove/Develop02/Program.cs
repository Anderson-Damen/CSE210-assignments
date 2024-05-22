using System;
using System.IO;

class Program
{
    static public Journal journal;
    static void Main(string[] args)
    {
        int input = 0;
        while (input != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();
            input = int.Parse(userInput);
            Journal journal = new Journal();

        
            if (input == 1)
            {
                journal.Write();
            }
            else if (input == 2)
            {
                journal.Display();
            }
            else if (input == 3)
            {
                journal.Load();
            }
            else if (input == 4)
            {
                journal.Save();
            }
            else if (input == 5)
            {
                return;
            }
        }
    }
}