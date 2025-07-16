public class Entry
{
    public string _date;
    public string _promptIdea;
    public string _entryText;

    public Entry(string date, string prompt, string entryText)
    {
        _date = date;
        _promptIdea = prompt;
        _entryText = entryText;
    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptIdea}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(); //Empty line
    }
}