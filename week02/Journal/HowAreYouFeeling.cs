using System;

public class HowAreYouFeeling
{
    public string MoodRating()
    {
        Console.WriteLine("\nBefore you leave, let's track your daily mood!");
        Console.WriteLine("Please rate your day on a scale from 1 to 5, where:");
        Console.WriteLine("1: Terrible 😫");
        Console.WriteLine("2: Not so well... 😞");
        Console.WriteLine("3: Bleh! 😐");
        Console.WriteLine("4: Not bad at all! 😊");
        Console.WriteLine("5: Today was a great day! 🤩");
        Console.WriteLine();

        Console.Write("Your mood rating (1-5): ");
        string inputRating = Console.ReadLine();

        int numericRating;
        string moodDescription = "Invalid option. ";

        if (int.TryParse(inputRating, out numericRating))
        {
            switch (numericRating)
            {
                case 1:
                    moodDescription = "Terrible 😫";
                    break;
                case 2:
                    moodDescription = "Not so well... 😞";
                    break;
                case 3:
                    moodDescription = "Bleh! 😐";
                    break;
                case 4:
                    moodDescription = "Not bad at all! 😊";
                    break;
                case 5:
                    moodDescription = "Today was a great day! 🤩";
                    break;
                default:
                    moodDescription = "Invalid option. Please try again. (1 - 5)";
                    break;
            }
        }
        else
        {
            moodDescription = "Invalid option. That is not a number";
        }

        return moodDescription;
    }
}