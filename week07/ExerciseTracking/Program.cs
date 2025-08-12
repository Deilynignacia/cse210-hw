using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Activities and values
        List<Activity> activities = new List<Activity>();
        Running running = new Running("12 August 2025", 40, 3.5f);
        Cycling cycling = new Cycling("13 August 2025", 120, 25.5f);
        Swimming swimming = new Swimming("11 August 2025", 30, 50);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("\n\x1b[1mEXERCISE TRACKING SUMMARY\x1b[0m\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}