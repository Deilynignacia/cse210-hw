using System;
using System.Diagnostics; // For the cronometer functionality

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Luke", 5, 27, 28);
        string scriptureText = "And after these things he went forth, and saw a publican, named Levi, sitting at the receipt of custom: and he said unto him, Follow me. And he left all, rose up, and followed him.";

        Scripture scripture = new Scripture(reference, scriptureText);

        string userInput = "";

        // Start cronometer
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            // Clean the console por avery turn
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\n-----------------------------------------------------");

            Console.Write("Press Enter to hide words and start the game, or type 'quit' to exit: ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(4);
            }
        }

        // Stop cronometer
        stopwatch.Stop();

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\n-----------------------------------------------------");

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine($"Congratulations! Every single word is hidden. You have memorized the scripture in {stopwatch.Elapsed.Minutes:00}:{stopwatch.Elapsed.Seconds:00} minutes!");
        }
        else
        {
            Console.WriteLine("See you next time!");
        }
    }
}