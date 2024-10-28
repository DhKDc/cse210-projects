using System;

class Program
{
    static void Main(string[] args)
    {
        EternalQuest quest = new EternalQuest();

        quest.AddGoal(new SimpleGoal("Run a Marathon", "Complete a full marathon", 1000));
        quest.AddGoal(new EternalGoal("Read Scriptures", "Study the scriptures daily", 100));
        quest.AddGoal(new ChecklistGoal("Attend Temple", "Visit the temple", 50, 10, 500));

        while (true)
        {
            Console.Clear(); 

            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. View Score");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    quest.DisplayGoals();
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    RecordEvent(quest);
                    CheckLevelUp(quest); 
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine($"Current Score: {quest.Score}");
                    Console.WriteLine($"Current Level: {quest.Level}");
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    CreateNewGoal(quest);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(EternalQuest quest)
    {
        Console.WriteLine("\nCreate New Goal:");
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();   


        Console.Write("Enter points value: ");
        if (int.TryParse(Console.ReadLine(), out int pointsValue))
        {
            Console.WriteLine("\nGoal Types:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            Console.Write("Enter  goal type number: ");
            string goalType = Console.ReadLine();

            switch (goalType)
            {
                case "1":
                    quest.AddGoal(new SimpleGoal(name, description, pointsValue));
                    break;
                case "2":
                    quest.AddGoal(new EternalGoal(name, description, pointsValue));
                    break;
                case "3":
                    Console.Write("Enter required count: ");
                    if (int.TryParse(Console.ReadLine(), out int requiredCount))
                    {
                        Console.Write("Enter bonus points: ");
                        if (int.TryParse(Console.ReadLine(), out int bonusPoints))
                        {
                            quest.AddGoal(new ChecklistGoal(name, description, pointsValue, requiredCount, bonusPoints));
                        }
                        else
                        {
                            Console.WriteLine("Invalid bonus points value.");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid required count value.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }

            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid points value.");
        }
    }

    static void RecordEvent(EternalQuest quest)
    {
        quest.DisplayGoals();

        Console.Write("\nEnter the number of the goal to record: ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber > 0 && goalNumber <= quest.Goals.Count)
        {
            quest.Goals[goalNumber - 1].RecordEvent(quest);
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void CheckLevelUp(EternalQuest quest)
    {
        int level = quest.Score / 1000; 

        if (level > quest.Level)
        {
            quest.Level = level;
            Console.WriteLine($"\nCongratulations! You've leveled up to Level {quest.Level}!");
            
            int bonusPoints = quest.Level * 100;
            quest.Score += bonusPoints;
            Console.WriteLine($"You've earned {bonusPoints} bonus points!");
        }
    }
}