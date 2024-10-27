using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = new List<string>(prompts);
        _questions = new List<string>(questions);
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter.");
        Console.ReadKey();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);

        int totalTime = _duration;
        int timePassed = 0;

        while (timePassed < totalTime)
        {
            DisplayQuestion();
            Thread.Sleep(5000);
            timePassed += 5;
        }
        
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {   
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
    }
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Question: {question}");
    }
}