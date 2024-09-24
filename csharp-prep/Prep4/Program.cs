using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("The sum is: " + (sum));

        Console.WriteLine("The average is: " + (sum / numbers.Count));

        int largest = 0;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The largest number is: " + (largest));

        int Small = 100000;
        foreach (int num in numbers)
        {
            if (num < Small && num > 0)
            {
                Small = num;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The smallest positive number is: " + (Small));
    }
}