using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = -1;

        Console.Write("Guess the magic number between 1 and 100: ");

        while (guess != number)
        {
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine("Would you like to play again? (yes/no)");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    number = randomGenerator.Next(1, 100);
                    guess = -1;
                    Console.Write("Guess the magic number between 1 and 100: ");
                }
                else
                {
                    break;
                }
            }
        }
    }
}