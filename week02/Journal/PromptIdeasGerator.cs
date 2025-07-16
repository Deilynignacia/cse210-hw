public class PromptIdeasGenerator
{
    public List<string> _prompts;

    public PromptIdeasGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "Describe a challenge you faced today and how you overcame it.",
            "What made me laugh today?",
            "What did I remember today that I hadn't thought about in a long time?",
            "What smell did I enjoy today?",
            "What scripture could help me with a challenge I faced today?",
            "Did something happen today that I'll laugh about in the future?",
            "What conversation stuck with me and why?",
            "If I could press the pause button on one moment today, what would it be and why?",
            "What song, book, movie, or piece of art resonated with me today? Why?",
            "What did today teach me about myself?",
            "Are there any new ideas or projects that came to mind today?",
            "How did I take care of myself today (physically, mentally, or emotionally)?",
            "What is something I'm anticipating this week?",
            "What was a moment of peace I experienced today?",
        };
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }

}