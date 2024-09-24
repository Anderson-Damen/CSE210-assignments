using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Course coursel = new Course();
        // coursel._classCode = "CSE 210";
        // coursel._classname = "programming with classes";
        // coursel._credits = 2;
        // coursel._color = "Green";

        // coursel.Display();
        string Operation = "";

            while (Operation != "5")
            {
            Console.Write("Enter First interger: ");
            int First_number = int.Parse(Console.ReadLine());

            Console.Write("Enter Second interger: ");
            int Second_number = int.Parse(Console.ReadLine());
        
            Console.WriteLine("1. Addistion");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Choose which operation you want to perform: ");
            Operation = Console.ReadLine();

            if (Operation == "1")
            {
                Console.WriteLine(First_number + Second_number);
            }
            else if (Operation == "2")
            {
                Console.WriteLine(First_number - Second_number);
            }
            else if (Operation == "3")
            {
                Console.WriteLine(First_number * Second_number);
            }
            else if (Operation == "4")
            {
                Console.WriteLine(First_number / Second_number);
            }
            else if (Operation == "5")
            {
                Console.WriteLine("Thank you for using the simple calculator!");
            }
        }
    }
}