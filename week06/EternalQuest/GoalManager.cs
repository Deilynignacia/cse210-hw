using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;
    private string _userName;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;

        Console.Write("Hail there!");
        Console.Write("Allow me to introduce myself. My name is Antay and I come from a legacy of Chroniclers of Destiny.");
        Console.Write("As well as those who came before me, I have witnessed and record countless of bold souls's");
        Console.Write("extraordinary quests. However, my dear, there is something in your kind spirit that have");
        Console.Write("caught my attention, and it would be my pleasure to be yours the next story in my scrolls.");
        Console.Write("");
        Console.Write("What is your name?");

        _userName = Console.ReadLine();

        Console.WriteLine($"\nBe welcome then, {_userName}.");
        Console.Write("");
        Console.Write("As you might know, almost every great story begins at the foot of the mountain,");
        Console.Write("and so does yours. You will start your journey as my Apprentice. But I must instruct you to");
        Console.Write("not be content with your current state. It is your sacred duty to rise above.");
        Console.Write("Now, listen to my words. This is the path awaiting for you: Create and complete quests, earn stars");
        Console.Write("and level up from Apprentice to The Chronicler's Chosen.");
    }

    public void Start()
    {
        string choice = "";

        do
        {
            Console.WriteLine($"\n▣ {_userName} the {GetTitle()} ▣");
            
            Console.WriteLine($"Total Stars: {_totalScore} ★");

            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine(" 1. Start a New Quest");
            Console.WriteLine(" 2. Check Your Quests");
            Console.WriteLine(" 3. Save Your Quests");
            Console.WriteLine(" 4. Look at Old Quests (Load)");
            Console.WriteLine(" 5. Mark a Quest as Done");
            Console.WriteLine(" 6. Quit");

            Console.Write("Choose wisely: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
            }

            else if (choice == "2")
            {
            }

            else if (choice == "3")
            {
            }

            else if (choice == "4")
            {
            }

            else if (choice == "5")
            {
            }

            else if (choice == "6")
            {
                Console.WriteLine($"\nFarewell, {_userName} the {GetTitle()}!");
            }

            else
            {
                Console.WriteLine("Try again, my dear.");
            }

        } while (choice != "6");
    }
    
    private string GetTitle()
    {
        if (_totalScore >= 10000) return "🧝🏻 The Chronicler's Chosen";
        if (_totalScore >= 5000) return "🥷🏻 Legend";
        if (_totalScore >= 3500)  return "🫅🏻 Sovereign";
        if (_totalScore >= 1000)  return "🧙🏻 Wizard";
        if (_totalScore >= 500)  return "🐉 Dragonslayer";
        if (_totalScore >= 350)  return "⚔️ Knight";
        if (_totalScore >= 220)  return "🌪️ Stormchaser";
        if (_totalScore >= 120)  return "🧭 Explorer";
        if (_totalScore >= 50)   return "📜 Scribe";
        return "🪶 Apprentice";
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nQuests types:");
        Console.WriteLine("  1. Simple Quest: Unique and decisive.");
        Console.WriteLine("  2. Eternal Quest: A  habit you vow to maintain.");
        Console.WriteLine("  3. Checklist Quest: A series of deeds that, when repeated, lead to a greater destiny.");

        Console.Write("Which quest type will you choose? ");
        string type = Console.ReadLine();

        Console.Write("What title shall this quest bear in my chronicles? ");
        string name = Console.ReadLine();

        Console.Write("Describe your quest for the record. ");
        string description = Console.ReadLine();

        Console.Write("How many ★ shall you get when it is done? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times must you complete this to unlock a greater reward? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("How many extra ★ will be your reward? ");
            int bonus = int.Parse(Console.ReadLine());
            
            _goals.Add(new CheckListGoal(name, description, points, 0, target, bonus));
        }
        else
        {
            Console.WriteLine("That quest type is unknown in these lands.");
        }
    } 
    private void ListGoals()
    {
        Console.WriteLine("\nCurrent Quests:");
        if (_goals.Count > 0)
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                string status = _goals[i].GetStatus();
                string name = _goals[i].GetName();

                Console.WriteLine($"{i + 1}. {status} {name}");
            }
        }
        else
        {
            Console.WriteLine("You have no current quests yet!");
        }
    }

    private void SaveGoals()
    {
        Console.Write("What name should I give the scroll for your quest? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.ToFileString());
            }
        }
        
        Console.WriteLine("Your legend has been written.");
    }

    private void LoadGoals()
    {
        Console.Write("Name the scroll to recall your legend: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            if (lines.Length > 0)
            {
                _totalScore = int.Parse(lines[0]);
                _goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    string type = parts[0];
                    string[] goalData = parts[1].Split('|');

                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);

                    Goal goal = null; 

                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(goalData[3]);
                        goal = new SimpleGoal(name, description, points, isComplete);
                    }
                    else if (type == "EternalGoal")
                    {
                        goal = new EternalGoal(name, description, points);
                    }
                    else if (type == "CheckListGoal")
                    {
                        int timesDone = int.Parse(goalData[3]);
                        int timesRequired = int.Parse(goalData[4]);
                        int bonus = int.Parse(goalData[5]);
                        goal = new CheckListGoal(name, description, points, timesDone, timesRequired, bonus);
                    }

                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
                Console.WriteLine("Your quests have been successfully restored.");
            }
            else
            {
                Console.WriteLine("This is empty, my dear.");
            }
        }
        else
        {
            Console.WriteLine("I don't have it in my records!");
        }
    }

        private void RecordEvent()
        {
            Console.WriteLine("\nIt is my duty as Chronicler to record your triumphs. Which quest have you completed?");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }

            Console.Write("Inscribe the number of the completed quest: ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                string oldTitle = GetTitle();
                int pointsEarned = _goals[goalIndex].RecordEvent();
                _totalScore += pointsEarned;

                Console.WriteLine($"\n✨ Well done {GetTitle}! You are rewarded with {pointsEarned} ★!");
                Console.WriteLine($"You now have {_totalScore} ★ in total.");

                string newTitle = GetTitle();
                if (newTitle != oldTitle)
                {
                    Console.WriteLine($"\nCongratulations! You have ascended to {newTitle}!");
                }
            }
            else
            {
                Console.WriteLine("I find no record of that quest in the archives...");
            }
        }
    }