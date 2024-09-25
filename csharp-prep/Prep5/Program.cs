using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        static void PromptUserName(string user_name)
        {
                Console.WriteLine("Please enter your name? ");
                user_name = Console.ReadLine();
        }
        
        static void PromptUserNumber(int user_number)
        {
            Console.Write("Please enter your favorite number? ");
            user_number = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int user_number)
        {
            return user_number * user_number;
        }

        static void DisplayResult(int squared_number, string user_name, int user_number)
    }
}