public class ProgramMeneger
{

    public int totalCalories;
     public void GetStart()
     {
         CaloriesTracker caloriesTracker = new CaloriesTracker();
         
        while(true){
       Console.WriteLine($"Total Calorie of the day:{totalCalories}");

       Console.WriteLine("Welcome to the Calories and Meals Program!");
       Console.WriteLine("Menu:");
       Console.WriteLine("1. Calculate your kcal needs");
       Console.WriteLine("2. Record Meal");
       Console.WriteLine("3. Save Meal Record");
       Console.WriteLine("4. Display Meal Record");
       Console.WriteLine("5. Set a Goal"); 
       Console.WriteLine("6. Quit"); 
       Console.WriteLine("Select on the options from the menu:");
       string userChoice = Console.ReadLine();

       if (userChoice=="1")
       {
        Calculation calculation = new Calculation();
        calculation.CalculationCalories();
       }

       else if (userChoice=="2")
       {
        Console.WriteLine("Enter the type of meal do you want to record:");
        Console.WriteLine("1. Sneak \n 2. Complete Meal");
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
       }

       else if (userChoice=="3")
       {
           File file = new File();
           Console.WriteLine("Enter file path to save:");
    
         string filename= Console.ReadLine();
           file.SaveInFile(filename, caloriesTracker.GetValues());
           Console.WriteLine("Meal Saved!");

        
       }
        }

     }

}