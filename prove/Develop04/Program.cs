using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int quit = 0;
        while (quit != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start Listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            quit = choice;
        }

        Activity activity = new Activity("My cool activity", "This is a cool activity", 20);
        Breathing breathingactivity = new Breathing("Breathing", "This activity will help you relax by walking through breathing in and out. Clear your mind and focus on your breathing.", 30);
        breathingactivity.animation();
        Reflection reflectionactivity = new Reflection("Reflection", "This is a cool activity", 40);
        Lister listeractivity = new Lister("Lister", "", 50);

    }
}