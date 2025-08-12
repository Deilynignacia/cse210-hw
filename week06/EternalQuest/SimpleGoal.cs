public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        return _isComplete ? "★" : "☆";
    }

    public override string ToFileString()
    {
        return $"SimpleGoal:{_name}|{_description}|{_points}|{_isComplete}";
    }
}