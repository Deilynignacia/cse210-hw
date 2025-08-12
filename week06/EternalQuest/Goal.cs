using System.Security.Cryptography;

public abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;

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

    public abstract string ToFileString();
    
    public abstract bool IsComplete();
}