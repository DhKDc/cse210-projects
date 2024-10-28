public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int PointsValue { get; set; }
    public bool IsComplete { get; protected set; } 

    public Goal(string name, string description, int pointsValue)
    {
        Name = name;
        Description = description;
        PointsValue = pointsValue;
        IsComplete = false;
    }

    public abstract void RecordEvent(EternalQuest quest); 
}