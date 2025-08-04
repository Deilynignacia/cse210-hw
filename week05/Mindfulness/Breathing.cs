public class Breathing : Mindfulness
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    
    public override void RunActivity()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("Breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }            
        }
        DisplayEndingMessage();
    }

}