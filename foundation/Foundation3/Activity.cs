using System;

public abstract class Activity
{
    private DateTime _date;
    private int _activityLength; 

    protected Activity(DateTime date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public int GetActivityLength()
    {
        return _activityLength;
    }
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_activityLength} min) - Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}