using System.Collections.Generic;

public class EternalQuest
{
    public List<Goal> Goals { get; } = new List<Goal>();
    public int Score { get; set; } = 0;
    public int Level { get; set; } = 1;

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Goal goal = Goals[i];
            string completionStatus = goal.IsComplete ? "[X]" : "[ ]";

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{i + 1}. {goal.Name} ({completionStatus} - {checklistGoal.CurrentCount}/{checklistGoal.RequiredCount})");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {goal.Name} ({completionStatus})");
            }
        }
    }
}