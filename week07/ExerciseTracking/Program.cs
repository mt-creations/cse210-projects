using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2026, 01, 01), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2026, 01, 12), 60, 7.0));
        activities.Add(new Swimming(new DateTime(2026, 02, 05), 30, 25));

        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        
        Console.WriteLine();
    }
}