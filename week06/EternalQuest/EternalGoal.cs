public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStatus()
    {
        return "☆";
    }
    public override string ToFileString()
    {
        return $"EternalGoal:{_name}|{_description}|{_points}";
    }
}