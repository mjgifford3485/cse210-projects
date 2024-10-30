using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals;
    private PlayerLevel _playerLevel;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _playerLevel = new PlayerLevel(0);
    }
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("1. Display Player Info\n2. List Goal Names\n3. Create Goal\n4. Record Event\n5. Save Goals\n6. Load Goals\n7. Exit");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_playerLevel.GetPlayerInfo());
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Enter Goal Type (Simple/ Eternal/ Checklist)");
        string type = Console.ReadLine();
        Console.WriteLine("Enter Short Name: ");
        string shortName = Console.ReadLine();
        Console.WriteLine("Enter Description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter Points: ");
        string points = Console.ReadLine();
        int pointsValue = int.Parse(points);

        if (type.Equals("Simple", StringComparison.OrdinalIgnoreCase))
        {
            _goals.Add(new SimpleGoal(shortName, description, points));
        }
        else if (type.Equals("Eternal", StringComparison.OrdinalIgnoreCase))
        {
            _goals.Add(new EternalGoal(shortName, description, points));
        }
        else if (type.Equals("Checklist", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Enter Target");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(shortName, description, points, 0, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid Goal Type");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Enter Goal Name to record event: ");
        string shortName = Console.ReadLine();
        foreach (var goal in _goals)
        {
            if (goal.GetShortName().Equals(shortName, StringComparison.OrdinalIgnoreCase))
            {
                goal.RecordEvent();
                if (goal.IsComplete())
                {
                    int pointsEarned = goal.GetPointsValue();
                    _playerLevel.UpdateScore(_playerLevel.GetScore() + pointsEarned);
                }
                break;
            }
        }
        Console.WriteLine($"Total Score: {_playerLevel.GetScore()}");   
    }
    public void SaveGoals()
    {
        Console.WriteLine("Please enter a name for your save file:");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        { 
            foreach (var goal in _goals)
                {
                    string goalData = $"{goal.GetGoalType()}, {goal.GetShortName()}, {goal.GetDescription()}, {goal.GetPoints()}, {goal.IsComplete()}";
                    outputFile.WriteLine(goalData);
                }
        }
        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals()
    {
        Console.WriteLine("Please enter the name of the file you would like to load:");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                
                if (parts.Length >= 5)
                {
                    string goalType = parts[0].Trim();
                    string shortName = parts[1].Trim();
                    string description = parts[2].Trim();
                    string points = parts[3].Trim();
                    bool isComplete = bool.Parse(parts[4].Trim());

                    switch (goalType.ToLower())
                    {
                        case "simple":
                            _goals.Add(new SimpleGoal(shortName, description, points));
                            break;
          
                        case "eternal":
                            _goals.Add(new EternalGoal(shortName, description, points));
                            break;

                        case "checklist":
                            if (parts.Length >= 7 && int.TryParse(parts[5].Trim(), out int target) && int.TryParse(parts[6].Trim(), out int bonus))
                            {
                                _goals.Add(new CheckListGoal(shortName, description, points, isComplete ? target : 0, target, bonus));
                            }
                            break;

                        default:
                            Console.WriteLine($"Unknown Goal Type: {goalType}");
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
    }
}