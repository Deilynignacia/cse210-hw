public class Activity
{
    private string _date;
    private float _duration;

    public Activity(string date, float duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual float GetDuration()
    {
        return _duration;
    }
    
    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return 0;
    }

    public virtual float GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return
        $"{_date}\n" +
        $"{GetType().Name} ({_duration} min)\n" +
        $"Distance: {GetDistance():f2} km\n" +
        $"Speed: {GetSpeed():f2} kph\n" +
        $"Pace: {GetPace():f2} min per km\n";
    }
}