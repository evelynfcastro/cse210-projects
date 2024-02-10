public class EternalGoal : Goals
{
    public EternalGoal(string name, string description, int points) :base(name,description, points)
    {

    }
    public EternalGoal()
    {

    }

     public void GetStart()
    {
        GetStringRepresentation();
    }
      public override string GetStringRepresentation()
    {
        
          return  $"Eternal Goal, {GetName()}, {GetDescription()}, {GetPoints()}";
    }
     public override void RecordEvent()
    {
        // Implement recording event for SimpleGoal
        Console.WriteLine("Recording event for Eternal Goal.");
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }
}