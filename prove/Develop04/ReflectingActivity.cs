using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> prompts;
    private List<string> questions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "What would you do differently next time?",
            "What are you most proud of in this experience?",
            "What was the most challenging part of this experience?",
            "What was the most rewarding part of this experience?",
            "What was the most surprising part of this experience?",
        };
    }

    public void Run()
    {
        Start();
        Random random = new Random();
        List<string> remainingPrompts = new List<string>(prompts);
        string prompt;

        if (remainingPrompts.Count == 0)
        {
            remainingPrompts = new List<string>(prompts); // Repopulate the list when all prompts have been used
        }

        int index = random.Next(remainingPrompts.Count);
        prompt = remainingPrompts[index];
        remainingPrompts.RemoveAt(index); // Remove the selected prompt from the list

        Console.WriteLine(prompt);

        DateTime endTime = getDuration();
        while (DateTime.Now < endTime)
        {
            string question = questions[random.Next(questions.Count)];
            Console.WriteLine(question);
            PauseWithSpinner(5); // Pause for 5 seconds per question
        }
        End();
    }
}
