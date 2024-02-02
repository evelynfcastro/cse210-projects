using System.Runtime.InteropServices.Marshalling;

public class BreathingActivity : Activity
{
   
  public void Run(int duration)
   
  {
    DisplayStartingMessage("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");

    //DateTime startTime = DateTime.Now;
    //DateTime futureTime = startTime.AddSeconds(duration);
//
    //Thread.Sleep(3000);
    DateTime startTime = DateTime.Now;
    TimeSpan durations = TimeSpan.FromSeconds(duration);  // Replace 10 with your desired duration
    DateTime futureTime = startTime + durations;
   
   while (DateTime.Now < futureTime)
  {
    DateTime currentTime = DateTime.Now;

    
    Console.Write("Breath in....");
    ShowCountDown(1000);
    Thread.Sleep(1000);
    Console.WriteLine();
    Console.Write("Breath out....");
    ShowCountDown(1000);
    Thread.Sleep(1000);
    Console.WriteLine();
  }
    DisplayEndingMessage("Breathing Activity", duration);
  }
}