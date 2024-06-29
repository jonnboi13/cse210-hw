using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _totalPoints = 0;

    public static void Main(string[] args)
    {
        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoals();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    Console.WriteLine($"Total Points: {_totalPoints}");
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. List Goals");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Show Score");
        Console.WriteLine("7. Quit");
        Console.Write("Enter your choice: ");
    }

    private static void CreateNewGoal()
    {
        Console.Write("Enter goal type (1: Simple, 2: Eternal, 3: Checklist, 4: Negative): ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target number of times: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonusPoints));
                break;
            case "4":
                _goals.Add(new NegativeGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.Write("Enter goal index to record event: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            int points = goal.RecordEvent();
            _totalPoints += points;

            Console.WriteLine($"Event recorded. Points gained: {points}");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    private static void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i}. {goal.GetStatus()} {goal.Name} ({goal.Description}) - {goal.Points} points");
        }
    }

    private static void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(_totalPoints);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.Serialize());
        }

        Console.WriteLine("Goals saved.");
    }

    private static void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using StreamReader reader = new StreamReader(filename);
            _totalPoints = int.Parse(reader.ReadLine());
            _goals.Clear();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                string type = data[0];

                Goal goal = type switch
                {
                    "SimpleGoal" => new SimpleGoal("", "", 0),
                    "EternalGoal" => new EternalGoal("", "", 0),
                    "ChecklistGoal" => new ChecklistGoal("", "", 0, 0, 0),
                    "NegativeGoal" => new NegativeGoal("", "", 0),
                    _ => null
                };

                if (goal != null)
                {
                    goal.Deserialize(data);
                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
