// This class demonstrates how to create Job and Resume objects and display resume information.

using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Daily Planet";
        job1._jobTitle = "Reporter";
        job1._startYear = 1938;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "World";
        job2._jobTitle = "Superheroe";
        job2._startYear = 1938;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Clark Kent";

        myResume._personsJobs.Add(job1);
        myResume._personsJobs.Add(job2);

        myResume.Display();
    }
}