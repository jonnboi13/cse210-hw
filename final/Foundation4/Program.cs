using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0), // Running 30 minutes, 3 miles
            new Cycling("04 Nov 2022", 45, 15.0), // Cycling 45 minutes, 15 mph
            new Swimming("05 Nov 2022", 60, 20) // Swimming 60 minutes, 20 laps
        };

        Console.WriteLine("Activities:");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
