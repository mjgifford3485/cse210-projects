using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base (name, description, duration)
    {
        _count = count;
        _prompts = new List<string>(prompts);
    }


    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Press enter when ready.");
        Console.ReadKey();
        List<string> userResponses = GetListFromUser();
        Console.WriteLine("Your responses: ");
        foreach (var response in userResponses)
        {
            Console.WriteLine($"- {response}");
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser()
    { 
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> userList = new List<string>();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can:");
        
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            userList.Add(input);
        }
        return userList;
    }
}