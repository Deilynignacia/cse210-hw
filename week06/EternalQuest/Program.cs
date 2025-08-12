// In order to  show creativity and exceed requirements, the program has been gamified with an epic theme. 
// The goals track system was change into a quests one.  The user begins their journey as an "Apprentice" 
// to the "Chronicler of Destiny", the narrator of the program, and is intended to level up until becoming 
// the Chronicler's Chosen (there are ten levels). The score is measured in stars, with an empty star (☆) 
// representing an unaccomplished quest and a filled star (★) indicating a completed one. This proporcionates
// the user a gratifying experience, creating the feeling of progration and constant growth.

using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}