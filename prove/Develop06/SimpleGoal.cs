public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointsValue)
        : base(name, description, pointsValue) { }

    public override void RecordEvent(EternalQuest quest)
    {
        IsComplete = true;
        quest.Score += PointsValue;
    }
}