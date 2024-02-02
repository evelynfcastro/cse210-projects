public class GratitudeActivity : Activity
{
    private List<string> _gratitude = new List<string>{"Foods your are grateful for:",
    "People you are grateful for", 
    "Experiences you are grateful for:", 
    "Books you are grateful for"};

    
    public void Run(int duration)
    {
        DisplayStartingMessage("Gratitude Activity", "This activity will help you reflect on the  things your are grateful in your life by having you list them"); 
        Console.Clear();
        DisplayPromptNumber();
        GetListFromUser(duration);
        DisplayEndingMessage("Gratitude Activity", duration);

    }
    
    
    public string GetRandomPrompt1()
    {
        Random random = new Random();
        int randomIndex= random.Next(_gratitude.Count);
        string randomPrompt = _gratitude[randomIndex];
        return randomPrompt;
    }
    public int GetRandomNumber()
    {
        Random random = new Random();
         int minValue = 3;
        int maxValue = 10;
        int randomInRange = random.Next(minValue, maxValue + 1);
        return randomInRange;
    }
    public void DisplayPromptNumber()
    {
         Console.WriteLine("List the number of items asked to the following prompt:");
         Console.WriteLine($"------- List {GetRandomNumber()} {GetRandomPrompt1()}------");
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
       
        
     
   }
}
}