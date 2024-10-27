using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        ShowSpinner(3);

        int cycleDuration = 8;
        int totalCycles = _duration / cycleDuration;

        for (int i = 0; i < totalCycles; i++)
        {
            Console.WriteLine("Breath in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}