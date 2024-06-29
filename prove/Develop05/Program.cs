using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Eevent");
        Console.WriteLine("  6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        while (choice != 6)
        {
            switch (choice)
            {
                case 1:
                    // Create New Goal
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. CheckList Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    int goalType = int.Parse(Console.ReadLine());
                    


                    break;
                case 2:
                    // List Goals
                    break;
                case 3:
                    // Save Goals
                    break;
                case 4:
                    // Load Goals
                    break;
                case 5:
                    // Record Event
                    break;
                case 6:
                    // Quit
                    break;
            }
        }
    }
}