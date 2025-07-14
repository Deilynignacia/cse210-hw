//This class keeps track of the person's name and a list of their jobs.

using System;

public class Resume
{
    public string _name;
    public List<Job> _personsJobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _personsJobs)
        {
            job.Display();
        }
    }
}