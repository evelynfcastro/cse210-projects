using System.Runtime.CompilerServices;
using System.Security.Authentication;

class SimpleGoal : Goals
{
     public SimpleGoal()
     {

     }
    public SimpleGoal(string name, string description, int points) :base(name,description, points)
    {

    }
    
    public void GetStart()
    {
        GetStringInformation();
        
    }
    public override string GetStringRepresentation()
    {
        
          return  $"Simple Goal, {GetName()}, {GetDescription()}, {GetPoints()}";
    }
 
     public override void RecordEvent()
    {
        // Implement recording event for SimpleGoal
        Console.WriteLine("Recording event for SimpleGoal.");
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }


}