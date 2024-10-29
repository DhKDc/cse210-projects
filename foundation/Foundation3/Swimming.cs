using System;

public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / Duration) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return Duration / distance;
    }
}