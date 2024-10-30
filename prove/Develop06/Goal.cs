using System;

public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public string GetPoints()
    {
        
        return _points;
    }

    public virtual int GetPointsValue()
    {
        return int.Parse(_points);
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public virtual void RecordEvent()
    {
   
    }
    public virtual bool IsComplete() => false;

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName} [ ]";
    }
    public virtual string GetGoalType()
    {
        return "Goal";
    }
}