using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running("18 Apr 2025", 43, 18);
        activities.Add(running);

        Cycling cycling = new Cycling("17 Apr 2025", 28, 20);
        activities.Add(cycling);

        Swimming swimming = new Swimming("16 Apr 2025", 52, 30);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}