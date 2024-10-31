using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime dateTime, int activityLength, int laps) : base(dateTime, activityLength)
    {
        _laps = laps;     
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetActivityLength()) * 60;
    }
    public override double GetPace()
    {
        return GetActivityLength() / GetDistance();
    }
}