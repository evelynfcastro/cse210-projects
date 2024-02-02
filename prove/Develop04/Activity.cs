using System.Collections.Specialized;
using System.Reflection.Metadata;

public class Activity
{
  
  private string _name;
  protected int _duration;

  private string _description;

 public void SetUserChoice(string activity)
 {
    _name= activity;
 }
  public string GetUSerChoice()
  {
    return _name;
  }

public void SetTime(int duration)
{
    _duration= duration;
}
   public int GetUSerTime()
  {
    return _duration;
  }

public Activity()
{

}
  
public string GetActivityDescription()
  {
    return _description;
  }
  public void DisplayStartingMessage(string name, string discription)
  {
              Console.WriteLine($"Welcome to the {name}");

              Console.WriteLine(discription);
              Console.Write("Getting Ready...");
              ShowSpinner(1000);
              Console.WriteLine();
              
  }
  public void DisplayEndingMessage( string userActivity, int duration)
  {
     Console.WriteLine($"Well Done! \n You have completed {duration} seconds of {userActivity}");
     Thread.Sleep(2000);
     Console.Clear();
  }

  public void ShowSpinner(int seconds) 
  {
    List<string> animation = new List<string>();
    animation.Add("|");
    animation.Add("/");
    animation.Add("-");
    animation.Add("\\");
    animation.Add("|");
    animation.Add("/");
    animation.Add("-");
    animation.Add("\\");
    animation.Add("|");
    animation.Add("/");
    animation.Add("-");
    animation.Add("\\");
  

    foreach (string s in animation)
    {
        Console.Write(s);
        Thread.Sleep(seconds);
        Console.Write("\b \b");
    }

  }
  public void ShowCountDown(int second) 
  {
    for (int i =5; i>0; i--)
    {
        Console.Write(i);
        Thread.Sleep(second);
        Console.Write("\b \b");
    }
  }
}