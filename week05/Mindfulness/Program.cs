using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing breathingActivity = new Breathing();
                breathingActivity.RunActivity();
            }

            else if (choice == "2")
            {
                Reflection reflectionActivity = new Reflection();
                reflectionActivity.RunActivity();
            }

            else if (choice == "3")
            {
                Listing listingsActivity = new Listing();
                listingsActivity.RunActivity();
            }
            else if (choice == "4")
            {
                Console.WriteLine("You can come back whenever you feel you need a breack.");
                break;
            }
            else
            {
                Console.WriteLine("That is not an option. Please try again.");
            }
        }
    }
}