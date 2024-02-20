public class ProgramMeneger
{

    public int totalCalories;
    public int _calorieGoalNum;
     public void GetStart()
     {
         CaloriesTracker caloriesTracker = new CaloriesTracker();
         
        while(true){
       Console.WriteLine($"Total Calorie of the day:{totalCalories}");

       Console.WriteLine("Welcome to the Calories and Meals Program!");
       Console.WriteLine("Menu:");
       Console.WriteLine("1. Calculate your kcal needs");
       Console.WriteLine("2. Set a Goal");
       Console.WriteLine("3. Record Meal");
       Console.WriteLine("4. Save Meal Record");
       Console.WriteLine("5. Display Meal Record");
       Console.WriteLine("6. Quit"); 
       Console.WriteLine("Select on the options from the menu:");
       string userChoice = Console.ReadLine();
       Console.Clear();

       if (userChoice=="1")
       {
        Calculation calculation = new Calculation();
        calculation.CalculationCalories();
       }

       else if (userChoice=="3")
       {
        Console.WriteLine("Enter the type of meal do you want to record:");
        Console.WriteLine("1. Sneak \n2. Complete Meal");
        string typeMeal = Console.ReadLine();
        if (typeMeal == "1")
        {
            Sneaks sneaks = new Sneaks();
            sneaks.GetSneaksInformation();
            caloriesTracker.AddList(sneaks.AddToList());
            totalCalories = totalCalories + sneaks.TrackCalories();
        }
        else if (typeMeal =="2")
        {
            CompleteMeal completeMeal = new CompleteMeal();
            completeMeal.GetCompleteMealInformation();
            caloriesTracker.AddList(completeMeal.AddToList());
            totalCalories = totalCalories + completeMeal.TrackCalories();
            
        }


         if (_calorieGoalNum > totalCalories)
        {
            int difference= _calorieGoalNum - totalCalories;
            Console.WriteLine($"You still have:{difference} kcl to ingest");
        }
        else if(_calorieGoalNum == totalCalories)
        {
            Console.WriteLine("You acheived your calories goal for the day!");
        }
        else if(_calorieGoalNum < totalCalories)
        {
            Console.WriteLine("You exceed your daily calorie count!");
        }

       }

       else if (userChoice=="4")
       {
           File file = new File();
           Console.WriteLine("Enter file path to save:");
    
         string filename= Console.ReadLine();
           file.SaveInFile(filename, caloriesTracker.GetValues());
           Console.WriteLine("Meal Saved!");

        
       }
       else if (userChoice == "5")
       {
        File file = new File();
        Console.WriteLine("Enter the file path to Upload:");
        string filename = Console.ReadLine();
        file.LoadFile(filename);

       }
       else if (userChoice== "2")
       {
        Console.WriteLine("Enter your calories goal for today:");
        string calorieGoal= Console.ReadLine();
         _calorieGoalNum= int.Parse(calorieGoal);
       }
       
    else if (userChoice=="6")
    {
        break;
    }

       }
        }

     }

