using System;
using System.Threading;

public class Activity
{
    private string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good Job!");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i ++;

            if (i >= animationStrings.Count)
            {
                i=0;
            }
        }
    }
    public void ShowCountDown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i >= 10)
            {
                Console.Write("\b\b  \b\b");
            }
            else 
            {
                Console.Write("\b \b");
            }
        }   
    }

    public int GetActivityDuration()
    {
        Console.Write("How long in, seconds, would you like your session? ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            {
                return duration;
            }
            Console.WriteLine("Please enter a valid number: ");
        }
    } 
}