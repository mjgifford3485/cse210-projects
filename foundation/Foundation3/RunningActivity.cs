using System;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / GetActivityLength()) * 60;
    }
    public override double GetPace()
    {
        return GetActivityLength() / _distance;
    }
}