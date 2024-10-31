using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;

        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(currentDate, 30, 3.0),
            new StationaryBicycleActivity(currentDate, 30, 12.0),
            new SwimmingActivity(currentDate, 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}