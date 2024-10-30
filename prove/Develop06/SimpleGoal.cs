using System;
using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points) : base (shortName, description, points)
    {
        _isComplete = false;
    }
    
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            Console.WriteLine("Do you want to mark this goal as complete? (yes/no)");
            var response = Console.ReadLine();
            if (response.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                _isComplete = true;
                Console.WriteLine("Congratulations?  You completed a goal!");
                Console.WriteLine($"You earned {GetPointsValue()} points!");
            }
            else
            {
                Console.WriteLine("Keep going, you can do it!");
            }
        }
        else
        {
            Console.WriteLine("You have already completed this goal. Work on another!");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{GetShortName()} [ {(IsComplete() ? "X" : " ")}]";
    }

    public override bool IsComplete() => _isComplete;

    public override string GetGoalType()
    {
        return "Simple";
    }
}