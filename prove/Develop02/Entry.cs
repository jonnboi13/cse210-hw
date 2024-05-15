using System;

public class Entry
{
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public string Prompt { get; set; }

    public Entry(string content, string prompt)
    {
        Content = content;
        Date = DateTime.Now;
        Prompt = prompt;
    }

    public Entry(string content, string prompt, DateTime date)
    {
        Content = content;
        Prompt = prompt;
        Date = date;
    }

    // Add a parameterless constructor
    public Entry()
    {
    }
}