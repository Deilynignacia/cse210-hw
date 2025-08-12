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