


using System.Drawing;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string selection = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        string points = Console.ReadLine();

        if (selection == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (selection == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        } 
        else if (selection == "3")
        {
            Console.Write("Target: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void ListGoalNames()
    {
        Console.Clear();
        Console.WriteLine("Your Goals:\n");

        for (int i =0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}, {status} {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Which goal did you accomplish?");

        for (int i = 0; i <_goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}, {status} {_goals[i].GetDetailsString()}");
        }

        Console.WriteLine("Select a Goal: ")

        int selection = int.Parse(Console.ReadLine()) - 1;
        int earned = _goals[selection].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points");
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        
    }

}