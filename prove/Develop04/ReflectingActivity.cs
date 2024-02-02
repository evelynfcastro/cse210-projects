public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {"Think of a time when you stood up for someone else",
    "Think of a time when you did something really difficult",
    "Think of a time when you helped someone in need"};
    
    private List<string> _question = new List<string>
    {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "What did you learn about yourself through this experience?"};

   
   public void Run(int duration)
   {  DisplayStartingMessage("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience.\n This will help you recognize the power you have and how you can use it in other aspects of your life");
      Console.Clear();
      DisplayPrompt();
      Console.WriteLine("Now ponder on the following questions releted to this experience");
      Console.WriteLine("You may beging in:");
      ShowCountDown(1000);
      Console.Clear();
      DisplayQuestion(duration);
      DisplayEndingMessage("Reflecting Activity", duration);

   }
   
    public string GetRandomPrompt()
    {
        Random random = new Random();
         int randomIndex= random.Next(_prompts.Count);
         string randomPrompt = _prompts[randomIndex];
         return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_question.Count);
        string randomQuestion =_question[randomIndex];
        return randomQuestion;

    }
     public void DisplayPrompt()
     {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---------{GetRandomPrompt()}---------");
        Thread.Sleep(1000);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
     }

     public void DisplayQuestion(int duration)
     {

        DateTime startTime = DateTime.Now;
        TimeSpan durations = TimeSpan.FromSeconds(duration);  
        DateTime futureTime = startTime + durations;
   
      while (DateTime.Now < futureTime)
     {
       DateTime currentTime = DateTime.Now;
       
       Console.WriteLine(GetRandomQuestion());
       Thread.Sleep(2000);
       ShowSpinner(1000);
       
     }

     }
}