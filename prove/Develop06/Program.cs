using System;

class Program
{
    // for creativity, created a class that updates the player's level and title depending on how many points they've earned
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}