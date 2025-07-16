// Showing Creativity and Exceeding Requirements
// To demonstrate creativity and exceed the requirements, I implemented three major features. These are:
//
// 1.  Mood Tracking System:
//     - I added a new class, 'HowAreYouFeeling.cs', for daily mood rating, which is displayed after the user chooses to quit (Option 5).
//       It is effective because the user cannot completely quit the program without rating their daily mood. This ensures
//       consistency, making sure that even if they didn't add an entry that day, at least their mood was registered.
//     - It works by converting numerical input (1-5) into descriptive short phrases (e.g., "Terrible 😫"),
//       which are saved to a separate file ('mood_ratings.txt') that is created after the user's first input.
//
// 2.  Robust Character Encoding:
//     - I first tried to implement an emoji tracker, which allowed the user to enter any emoji to rate their day. However, I had trouble
//       getting the user's input to show in the .txt file. Despite this, in my efforts to make this possible, I added a variety of
//       different features, such as ensuring that UTF-8 encoding for console I/O (`Console.OutputEncoding`, `Console.InputEncoding`)
//       and file writing (`StreamWriter` with `new UTF8Encoding(false)`) were used. These attributes ensure proper handling and display
//       of special characters and emojis, not just in the user's input, but also in the program's output, which I considered equally crucial.
//
// 3.  Expanded Prompt List:
//     - I significantly increased the number of random journal prompts, in the file named PromptIdeasGenerator.cs, offering greater 
//       variety to the user.

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptIdeasGenerator promptGenerator = new PromptIdeasGenerator();
        bool working = true;
        Console.OutputEncoding = Encoding.UTF8; 
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Welcome to your journal! A moment to close out the day and record your thoughts.");
        while (working)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option from 1 to 5: ");
            Console.WriteLine();

            string options = Console.ReadLine();
            Console.WriteLine();

            switch (options)
            {
                // Get a random prompt and add a new entry
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry(date, prompt, response);
                    journal.AddNewEntry(newEntry);
                    Console.WriteLine();
                    break;

                // Show all previous entries
                case "2":
                    journal.DisplayAllEntries();
                    Console.WriteLine();
                    break;

                // Ask the user to name of the file they want to save the journal to
                case "3":
                    Console.Write("Enter the filename you want to save to: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved successfully.\n");
                    Console.WriteLine();
                    break;

                // Load a journal from an existing file
                case "4":
                    journal.LoadFromFile();
                    Console.WriteLine();
                    break;

                // Mood rating and quit
                case "5":
                    HowAreYouFeeling moodTracker = new HowAreYouFeeling();
                    string mood = moodTracker.MoodRating();

                    try
                    {
                    using (StreamWriter writer = new StreamWriter("mood_ratings.txt", true, new UTF8Encoding(false)))
                    {
                    writer.WriteLine($"{DateTime.Now.ToShortDateString()} - {mood}");                   
                    }
                    Console.WriteLine("Your mood rating was saved to mood_ratings.txt ✔️");
                }                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving mood rating: {ex.Message}");
                    }
                    
                    Console.WriteLine("See you tomorrow!");
                    working = false;
                    break;
            
                // In case of error display
                default:
                    Console.WriteLine("Invalid option. Please try again. (1 - 5) \n");
                    Console.WriteLine();
                    break;
            }
        }
    }
}