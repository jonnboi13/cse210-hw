using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        Start();
        DateTime endTime = getDuration();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(4); // 4 seconds for breathing in
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(4); // 4 seconds for breathing out
        }
        End();
    }
}
