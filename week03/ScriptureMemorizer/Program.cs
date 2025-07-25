// In order to show creativity, I have incorporated some new features that enhance 
// the user experience. This program includes a stopwatch, utilizing the Stopwatch class
// from the System.Diagnostics namespace, to measure the time it takes for the user to 
// memorize the scripture, introducing a challenging element to the game. I also used
// colors with Console.ForegroundColor to visually differentiate the title, scripture text,
// time, and user prompts.Furthermore, a detailed welcome message with a brief game explanation,
// an initial pause with Console.ReadKey that allows the user to read the information before starting,
// and a farewell message.

// Additionally, the program ensures that punctuation marks are correctly displayed alongside 
// the words, providing a more accurate and polished presentation of the scripture. I added this
// later, after noticing that when displaying the scripture, the user could only see the words.

using System;
using System.Diagnostics; // For the stopwatch functionality

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine();
        Console.WriteLine("WELCOME TO THE SCRIPTURE MEMORIZER!");
        Console.WriteLine();

        Console.ResetColor();

        Console.WriteLine("This game will help you memorize scriptures by progressively hiding words.");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey(true);
        Console.Clear();

        Reference reference = new Reference("Luke", 5, 27, 28);
        string scriptureText = "And after these things he went forth, and saw a publican, named Levi, sitting at the receipt of custom: and he said unto him, Follow me. And he left all, rose up, and followed him.";

        Scripture scripture = new Scripture(reference, scriptureText);

        string userInput = "";

        // Start cronometer
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            // Clean the console before every turn
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("--------------------");

            // Add colors
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed.Minutes:00}:{stopwatch.Elapsed.Seconds:00}");

            Console.WriteLine("--------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Press Enter to hide words and start the game, or type 'quit' to exit: ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(5);
            }
        }

        // Stop stopwatch
        stopwatch.Stop();

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine($"Congratulations! Every single word is hidden. You have memorized the scripture in {stopwatch.Elapsed.Minutes:00}:{stopwatch.Elapsed.Seconds:00} minutes!");
            Console.WriteLine(); //Empty line
        }
        else
        {
            Console.WriteLine("See you next time!");
            Console.WriteLine(); //Empty line
        }
        
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("See you next time!");
        Console.WriteLine();
        Console.WriteLine("Press any key to finish...");
        Console.ReadKey(true);
    }
}