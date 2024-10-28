public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointsValue)
        : base(name, description, pointsValue) { }

    public override void RecordEvent(EternalQuest quest)
    {
        quest.Score += PointsValue; 
    }
}