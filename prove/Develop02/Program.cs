using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        string command = "";

        while (command != "exit")
        {
            Console.WriteLine("Please choose an option: write, display, save, load, exit");
            command = Console.ReadLine();

            if (command == "write")
            {
                string prompt = GetRandomPrompt();
                Console.WriteLine(prompt);
                string content = Console.ReadLine();
                journal.AddEntry(content, prompt);
            }
            else if (command == "display")
            {
                journal.DisplayEntries();
            }
            else if (command == "save")
            {
                Console.WriteLine("Enter filename:");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
            }
            else if (command == "load")
            {
                Console.WriteLine("Enter filename:");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
            }
            else if (command == "exit")
            {
                // Do nothing, the loop will exit
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }
    }

    private static Random random = new Random();

    public static string GetRandomPrompt()
    {
        int index = random.Next(Prompt.Prompts.Count);
        return Prompt.Prompts[index];
    }
}