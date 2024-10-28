public class ChecklistGoal : Goal
{
    public int RequiredCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int pointsValue, int requiredCount, int bonusPoints)
        : base(name, description, pointsValue)
    {
        RequiredCount = requiredCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordEvent(EternalQuest quest)
    {
        CurrentCount++;
        quest.Score += PointsValue;
        if (CurrentCount >= RequiredCount)
        {
            IsComplete = true;
            quest.Score += BonusPoints; 
        }
    }
}