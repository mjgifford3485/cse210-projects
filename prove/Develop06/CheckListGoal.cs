using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, string points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted ++;
            Console.WriteLine($"Event Recorded.  Amount Completed: {_amountCompleted}");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Goal Completed!  You receive a bonus of: {_bonus}");
            }
        }
    }
    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetDetailsString()
    {
        return $"{GetShortName()}: {GetDescription()} (Completed: {_amountCompleted}/{_target}, Bonus: {_bonus})";
    }
    public override string GetStringRepresentation()
    {
        return $"{GetShortName()} [ {(IsComplete() ? "X" : " ")} ] (Completed: {_amountCompleted}/{_target})";
    }
    public override string GetGoalType()
    {
        return "CheckList";
    }
}