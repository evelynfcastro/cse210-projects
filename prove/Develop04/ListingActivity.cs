using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Quic;
public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?"};
    private int _acount=0;

public void Ran(int duration)
{
    DisplayStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    DisplayRandomPrompt();
    GetListFromUser(duration);
    DisplayEndingMessage("Listing Activity", duration);
}
public string GetRandomPrompt()
{

    Random random = new Random();
    int randomIndex= random.Next(_prompts.Count);
    string randomPrompt = _prompts[randomIndex];
    return randomPrompt;
}

public void DisplayRandomPrompt()
{
    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine($"-------{GetRandomPrompt()}------");
    Console.WriteLine("You may begin:");
    ShowCountDown(900);
}
public void GetListFromUser(int _time)
{
    List<string> _userList = new List<string>();
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_time);
    DateTime currentTime = DateTime.Now;
    
   while (DateTime.Now < futureTime)
   {
    
        _userList.Add(Console.ReadLine());
        _acount= _acount+ 1;
        //Console.Write(".");
        
     
   }
   Console.WriteLine($"You wrote {_acount} items. Good Job!");

   
}


   
}