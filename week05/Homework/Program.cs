using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Inti Mamani", "English");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Hetu'u Tuki", "Fractions", "1.2", "2-4");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Kallfü Catrileo", "Chilean Native History", "Spanish persecution of the Mapuches in the Araucanía region.");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}