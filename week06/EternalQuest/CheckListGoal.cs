public class CheckListGoal : Goal
{
    private int _timesDone;
    private int _timesRequired;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int timesDone, int timesRequired, int bonus) : base(name, description, points)
    {
        _timesDone = timesDone;
        _timesRequired = timesRequired;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesDone++;
        int totalPoints = GetPoints();

        if (_timesDone >= _timesRequired)
        {
            totalPoints += _bonus;
        }

        return totalPoints;
    }

    public override bool IsComplete()
    {
        return _timesDone >= _timesRequired;
    }

    public override string GetStatus()
    {
        string status = "";
        // Stars system
        for (int i = 0; i < _timesRequired; i++)
        {
            if (i < _timesDone)
            {
                status += "★";
            }
            else
            {
                status += "☆";
            }
        }
        return $"[{status}] {GetName()} - {_timesDone}/{_timesRequired} times";
    }

    public override string ToFileString()
    {
        return $"CheckListGoal:{base.ToFileString()},{_timesDone},{_timesRequired},{_bonus}";
    }
}