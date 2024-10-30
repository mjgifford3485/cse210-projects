using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {

    }
    
    public override void RecordEvent()
    {
        Console.WriteLine("Event Recorded for Eternal Goal");
        Console.WriteLine($"You earned {GetPointsValue()} points!");
    }
    public override bool IsComplete() => false;
    public override string GetStringRepresentation()
    {
        return $"{GetShortName()} [ {(IsComplete() ? "X" : " ")}] (Eternal)";
    }
    public override string GetGoalType()
    {
        return "Eternal";
    }
}