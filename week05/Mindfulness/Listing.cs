public class Listing : Mindfulness
{
    private List<string> _prompts;

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void RunActivity()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        Random random = new Random();
        int index = random.Next(0, _prompts.Count);

        string prompt = _prompts[index];
        Console.WriteLine($"~ {prompt} ~");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(); 
        
        Console.WriteLine("Start listing items:");
        
        List<string> userItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(" > ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                userItems.Add(item);
            }
        }

        Console.WriteLine($"You listed {userItems.Count} items.");

        DisplayEndingMessage();
    }
}