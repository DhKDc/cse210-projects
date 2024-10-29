using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running(new DateTime(2022, 11, 03), 30, 3.0);
        Cycling cycle = new Cycling(new DateTime(2022, 11, 04), 45, 12.0);
        Swimming swim = new Swimming(new DateTime(2022, 11, 05), 60, 40);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}