public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, float duration, int numberOfLaps) : base(date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float GetDistance()
    {
        return (_numberOfLaps * 50) / 1000f;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override float GetPace()
    {
        return GetDuration() / GetDistance();
    }
}