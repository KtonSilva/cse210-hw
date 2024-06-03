using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Activity running = new Running(new DateTime(2024, 6, 1), 30, 3.0); // 3 miles in 30 minutes
        Activity cycling = new Cycling(new DateTime(2024, 6, 2), 45, 20.0); // 20 mph for 45 minutes
        Activity swimming = new Swimming(new DateTime(2024, 6, 3), 40, 30); // 30 laps in 40 minutes

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display activity summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('-', 40));
        }
    }
}
