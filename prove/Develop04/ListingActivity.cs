using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts;
    private List<string> remainingPrompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
        prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        remainingPrompts = new List<string>(prompts);
    }

    public void Run()
    {
        Start();
        Random random = new Random();
        string prompt;

        if (remainingPrompts.Count == 0)
        {
            remainingPrompts = new List<string>(prompts); // Repopulate the list when all prompts have been used
        }

        int index = random.Next(remainingPrompts.Count);
        prompt = remainingPrompts[index];
        remainingPrompts.RemoveAt(index); // Remove the selected prompt from the list

        Console.WriteLine(prompt);

        List<string> items = new List<string>();
        DateTime endTime = getDuration();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Keep listing items:");
            string item = Console.ReadLine();
            items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items.");
        End();
    }
}