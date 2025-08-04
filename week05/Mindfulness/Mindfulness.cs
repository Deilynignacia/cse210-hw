using System;
using System.Collections.Generic;
using System.Threading;
public abstract class Mindfulness
{
    private string _name;
    private string _description;
    public int _duration;

    public Mindfulness(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Get ready...");
        Pause(3);
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }

    public void Pause(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "―", "\\", "|", "/", "―", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Pause(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed a {_duration} seconds of the {_name} Activity.");
    }

    public abstract void RunActivity();
}