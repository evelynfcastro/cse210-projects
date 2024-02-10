using System.Dynamic;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Authentication;

public class ChecklistGoal : Goals
{
    private int _amountCompleted;
    private int completionCount = 0;
     public int CompletedCount { get; set; }
    public int Points { get; set; }
    public ChecklistGoal()
    {

    }
    public ChecklistGoal(string name, string description, int points, int amountCompleted) :base(name,description, points)
    {

        _amountCompleted=amountCompleted;
    }
public void SetAmoutCompleted(int amount)
{
    _amountCompleted=amount;
}
public int GetAmountComplete()
{
    return _amountCompleted;
}

public override void SetPoints( int points)
{
    Points = points;
}

public override int GetPoints()
{ 
    return Points;

}

     
    public override  void GetStringInformation()
    {

        Console.WriteLine("What is your goal name?");
        SetName(Console.ReadLine());
        Console.WriteLine("What is your goal's description?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many points this goal will have?");
        string points =Console.ReadLine();
        int ponts= int.Parse( points);
        SetPoints(ponts);
        Console.WriteLine("How many times do you wanto to complete this goal?");
        string userAnswer = Console.ReadLine();
        SetAmoutCompleted( int.Parse(userAnswer));
    }
       
    
    public override string GetStringRepresentation()
    {
        
          return  $"Check List, {GetName()}, {GetDescription()}, {GetPoints()}, {_amountCompleted}";
    }
     public override void RecordEvent()
    {
       for (int i = 0; i < 3; i++)
        {
            CompleteGoal(ref completionCount);
        }

        // Check and display completion status
        DisplayCompletionStatus(completionCount, _amountCompleted);
    }

    static void CompleteGoal(ref int completionCount)
    {
        // Simulate completing the goal
        // You can customize this part based on your actual goal completion logic
        Console.WriteLine("Goal completed!");

        // Increment the completion count
        completionCount++;
    }

    static void DisplayCompletionStatus(int completionCount, int totalGoalCount)
    {
        // Display how many times the goal has been completed
        Console.WriteLine($"You have completed the goal {completionCount} times.");

        // Calculate and display how many times are remaining
        int remainingCount = totalGoalCount - completionCount;
        Console.WriteLine($"You still need to complete the goal {remainingCount} times.");
    }

    

    public override bool IsComplete()
    {
        return isComplete;
    }

    
}