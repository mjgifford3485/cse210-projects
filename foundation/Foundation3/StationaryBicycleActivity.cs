using System;
using System.Runtime.CompilerServices;

public class StationaryBicycleActivity : Activity
{
    private double _speed;

    public StationaryBicycleActivity(DateTime dateTime, int activityLength, double speed) : base(dateTime, activityLength)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed / GetActivityLength() * 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}