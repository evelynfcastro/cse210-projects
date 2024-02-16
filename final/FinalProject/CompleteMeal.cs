using System.Runtime.InteropServices;

public class CompleteMeal: Meal
{
   private  string  _drinkName;
   private int _drinkCalories;
   private string _dessertName;
   private int _dessertCalories;


   public CompleteMeal()
   {

   }

   public void SetDrinkName( string drinkName)
   {
    _drinkName=drinkName;
   }
   public void SetDrinkCalories( int drinkCalories)
   {
    _drinkCalories=drinkCalories;
   }
   public void SetDessertName( string dessertName)
   {
    _dessertName=dessertName;
   }
   public void SetDessertCalories( int dessertCalories)
   {
    _dessertCalories=dessertCalories;
   }

   public string GetDrinkName()
   {
    return _drinkName;
   }
   public string GetDessertName()
   {
    return _dessertName;
   }
   public int GetDrinkCalories()
   {
    return _dessertCalories;
   }
   public int GetDessertCalories()
   {
    return _dessertCalories;
   }

   public void GetCompleteMealInformation()
   {
     GetMealInformation();
     Console.WriteLine("Enter the name of your drink: (if you didn't get a drink type 'None')");
     SetDrinkName(Console.ReadLine());
     Console.WriteLine("Enter your drink calories:(if you didn't get a drink type '0')");
     string stringcalories= Console.ReadLine();
     _drinkCalories= int.Parse(stringcalories);
     SetDrinkCalories(_drinkCalories);
     Console.WriteLine("Enter your dessert name:(if no desset type 'None')");
     SetDessertName(Console.ReadLine());
     Console.WriteLine("Enter the dessert calories:(if no dessert type '0')");
     string stringcaloriesdes= Console.ReadLine();
     _dessertCalories = int.Parse(stringcaloriesdes);
     SetDessertCalories(_dessertCalories);

   }

    public override string AddToList()
    {
       return $"Food {GetFoodName()} Calories:{GetFoodCalories()} Drink {GetDrinkName()} Calories: {GetDrinkCalories()} Dessert {GetDessertName()} Calories: {GetDessertCalories()} ";
    }

    public override int TrackCalories()
    {
        return GetFoodCalories() + GetDrinkCalories() + GetDessertCalories();
    }

}