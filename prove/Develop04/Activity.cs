// Activity.cs
using System;

public class Activity
{
    private string _name { get; set; }
    private string _description { get; set; }
    private int _duration { get; set; }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name} activity.");
        Console.WriteLine(_description);
        SetDuration();
        Prepare();
    }

    public void End()
    {
        Console.WriteLine($"Well done! You have completed the {_name} activity.");
        Console.WriteLine($"Duration: {_duration} seconds");
    }

    public DateTime getDuration()
    {
        return DateTime.Now.AddSeconds(_duration);
    }

    public void PauseWithSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        string[] spinner = { "-", "+" };
        int i = 0;
        while (DateTime.Now < endTime)
        {
            if (Console.IsOutputRedirected)
            {
                Console.Write("\b"); // Clear the previous character
                Console.Write(spinner[i]);
            }
            else
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("\b"); // Clear the previous character
                Console.Write(spinner[i]);
            }
            i = (i + 1) % spinner.Length;
            Thread.Sleep(250);
        }

        // Clear the spinner character after the loop end
        if (!Console.IsOutputRedirected)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" "); // Clear the spinner character
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }

    public void PauseWithCountdown(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            int remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;
            Console.Write($"\rTime remaining: {remainingSeconds} seconds   "); // Adding extra spaces to clear previous text
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine(" ");
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void Prepare()
    {
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(2); // Using spinner for a 2-second delay
    }
}
