using System;

public class Activity
{
    public DateTime Date { get; set; }
    public int Duration { get; set; }

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({Duration} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}