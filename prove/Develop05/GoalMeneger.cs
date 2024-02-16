using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

class GoalManager
{
    private List<string> goals = new List<string>();
    private List<string> completedGoals = new List<string>();
    int totalPoints = 0;
    int interemNumber1 = 1;
     int tentatives = 0;
      int interemNumber=1;
     ChecklistGoal checklistGoal1 = new ChecklistGoal();
    public void Start()
    {
        while (true){
        
       Console.WriteLine(totalPoints);
       Console.WriteLine("Menu Options:");
       Console.WriteLine("1. Create a New Goal");
       Console.WriteLine("2. List Goals");
       Console.WriteLine("3. Save Goals");
       Console.WriteLine("4. Load Goals");
       Console.WriteLine("5. Record Event");
       Console.WriteLine("6. Quit");
       Console.WriteLine("Select a Choice from the Menu:");
       string userChoice = Console.ReadLine();

       if (userChoice == "1")
       {
          Console.WriteLine("What is the type of goal do you want to creat?");
          Console.WriteLine("1.Simple Goal \n2.Eternal Goal \n3.Checklist Goal");
          Console.WriteLine("Which type of goal would like to create?");
          string typeGoal = Console.ReadLine();
            if (typeGoal == "1")
            {
                SimpleGoal simpleGoal1 = new SimpleGoal();
                simpleGoal1.GetStringInformation();
                goals.Add(simpleGoal1.GetStringRepresentation());
                
            }
            else if (typeGoal =="2")
            {
                EternalGoal eternalGoal1 = new EternalGoal();
                eternalGoal1.GetStringInformation();
                goals.Add(eternalGoal1.GetStringRepresentation());
            }

            else if (typeGoal =="3")
            {
                // checklistGoal1 = new ChecklistGoal();
                checklistGoal1.GetStringInformation();
                goals.Add(checklistGoal1.GetStringRepresentation());
            }
       }
       else if (userChoice =="2")
       {
         ListGoals();
       }
       else if (userChoice == "3")
       {
            Console.WriteLine("Enter file path to save:");
            string filePath = Console.ReadLine();
            SaveGoals(filePath);
       }
       else if (userChoice == "4")
       {
        Console.WriteLine("Enter file path to load: ");
        string fileToLoad = Console.ReadLine();
        LoadGoals(fileToLoad);

       }
       else if (userChoice == "5")
       {
         
         Console.WriteLine("These are the Goals:");
                DisplayGoalsName();
                Console.WriteLine("Enter the number of the goal you want to record an event for:");
                string userInput = Console.ReadLine();
                int goalNum = int.Parse(userInput);

                if (goalNum > 0 && goalNum <= goals.Count)
                {
                    RecordEvent(goalNum);
                }
                else
                {
                    Console.WriteLine("Invalid goal number. Please try again.");
                }
       }

       else if (userChoice == "6")
       {
        break;
       }

        
        }

    }

    public void DisplayGoalsName()
    {
         
          int index = 1;

    foreach (string lines in goals)
    {
        string[] itemsArray = lines.Split(',');

        if (itemsArray.Length >= 2)
        {
            Console.WriteLine($"Index {index}. {itemsArray[0]} Points= {itemsArray[3]} ");
            index++;
        }
    }
       
    }

    public void ListGoals()
    {
         
         foreach (string lines in goals)
         {
          
             string[] itemsArray = lines.Split(',');
    
                 if (itemsArray.Length >= 2)
        {
            Console.WriteLine($"{interemNumber++}. {itemsArray[0]} ({itemsArray[1]})");
        }
        else
        {
            // Handle the case where there are not enough elements in itemsArray
            Console.WriteLine($"{interemNumber++} [ ]Invalid Format");
        }
         }

        
    }

    

   

     public void RecordEvent(int goalNum)
    {
       int goalIndex = goalNum - 1;

    // Mark the goal as complete
    string completedGoal = goals[goalIndex];
    string[] itemsArray = completedGoal.Split(',');

    if (itemsArray[0] == "Simple Goal" || itemsArray[0] == "Eternal Goal")
    {
        Console.WriteLine($"{completedGoal} marked as completed!");
        Console.WriteLine($"You got {itemsArray[3]} points");
        int points = Convert.ToInt32(itemsArray[3]);
        totalPoints += points;
        string newValue = $"[X] {completedGoal}";
        goals[goalIndex] = newValue;




//animation

    Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            int left = random.Next(Console.WindowWidth);
            int top = random.Next(Console.WindowHeight / 2);

            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);

            Console.Write("*");

            Thread.Sleep(50); // Adjust the sleep duration for the desired animation speed
        }

        Console.ResetColor();
        Console.Clear();





    }
    else if (itemsArray[0] == "Check List")
    {
        // Here, you need to get the corresponding ChecklistGoal from the existing list
        //ChecklistGoal checklistGoal1 = new ChecklistGoal(); // Replace this line with getting the actual goal

       
       
       if (checklistGoal1.GetAmountComplete()-tentatives != 0 )
        {
            
            tentatives++;
            Console.WriteLine($"Part of {completedGoal} completed");
            int still = checklistGoal1.GetAmountComplete() - tentatives;
            Console.WriteLine($"You have more {still}/{checklistGoal1.GetAmountComplete()}");
            Console.WriteLine($"You got {checklistGoal1.GetPoints()} points");
             int points = Convert.ToInt32(itemsArray[3]);
             totalPoints += points;
             tentatives++;
          
        
        }
       
       
       else if (checklistGoal1.GetAmountComplete() == tentatives)
        {
            Console.WriteLine($"{completedGoal} marked as completed {checklistGoal1.CompletedCount} - {checklistGoal1.CompletedCount}");
            Console.WriteLine($"You got {itemsArray[3]} points");
             int points = Convert.ToInt32(itemsArray[3]);
             totalPoints += points;
             Console.WriteLine($"{itemsArray[0]}  marked as completed!");
             string newValue = $"[X] {completedGoal} = COMPLETE";
             goals[goalIndex] = newValue;
             
       Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            int left = random.Next(Console.WindowWidth);
            int top = random.Next(Console.WindowHeight / 2);

            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);

            Console.Write("*");

            Thread.Sleep(50); // Adjust the sleep duration for the desired animation speed
        }

        Console.ResetColor();
        Console.Clear();

       
       
       
        }

        
        
    }
    }

    public void SaveGoals(string filePath)
    {
          using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var item in goals)
            {
                writer.WriteLine(item);
            }
        }
    }

    public void LoadGoals(string filePath)
    {
          if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
            string fileContent = reader.ReadToEnd();

                // Display the content (you can process or manipulate it as needed)
                Console.WriteLine("File Content:");
                Console.WriteLine(fileContent);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
    
    public void ListCompletedGoals()
    {
        Console.WriteLine("Completed Goals:");
        foreach (string completedGoal in completedGoals)
        {
            Console.WriteLine(completedGoal);
        }
    }
}