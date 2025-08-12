public class Running : Activity
{
    private float _distance;

    public Running(string date, float duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }

    public override float GetPace()
    {
        return GetDuration() / _distance;
    }
}