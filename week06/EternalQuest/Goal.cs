using System.Security.Cryptography;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetStatus()
    {
        return "";
    }
    public abstract int RecordEvent();

    public virtual string ToFileString()
    {
        return $"{_name},{_description},{_points}";
    }
    
    public abstract bool IsComplete();
}