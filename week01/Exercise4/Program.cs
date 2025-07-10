using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber;

        Console.WriteLine("Welcome to the Number Analyzer!");

        while (true)
        {
            Console.Write("Enter a number to add to the list (enter 0 to quit): ");
            string userResponse = Console.ReadLine();
            if (int.TryParse(userResponse, out userNumber))
            {
                if (userNumber == 0)
                {
                    Console.WriteLine("Exiting number input.");
                    break;
                }
                numbers.Add(userNumber);
            }
            else
            {
                Console.WriteLine("Please enter a numeric value.");
            }
        }

        Console.WriteLine("\n--- Analysis Results ---");

        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of your numbers is: {sum}");

            float average = ((float)sum) / numbers.Count;

            Console.WriteLine($"The average among your numbers is: {average:F2}");

            int max = numbers[0]; 
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The maximum number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered to perform calculations.");
        }

        Console.WriteLine("\nThank you for choosing us! Press any key to exit.");
        Console.ReadKey();
    }
}