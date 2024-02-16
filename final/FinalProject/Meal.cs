public abstract class Meal
{
    private string  _foodName;
    private int _foodCalories;
    private string _timeOfMeal;

    public Meal()
    {

    }
    
    public void SetFoodName(string foodName)

    {
        _foodName=foodName;
    }

    public void SetFoodCalories(int foodCalories)

    {
         _foodCalories= foodCalories;
             }

    public void SetTimeOfMeal(string timeofmeal)

    {
        _timeOfMeal=timeofmeal;
    }

    public string GetFoodName()
    {
        return _foodName;
    }

    public int GetFoodCalories()
    {
        return _foodCalories;
    }

    public string GetMealTime()
    {
        return _timeOfMeal;
    }


    public virtual void GetMealInformation()
    {
        Console.WriteLine("Please enter the name of the food:");
        SetFoodName(Console.ReadLine());
        Console.WriteLine("Enter the number of calories of your food:");
        string foodCalor= Console.ReadLine();
        _foodCalories = int.Parse(foodCalor);
        SetFoodCalories(_foodCalories);
        Console.WriteLine("Add the time you ate the food:");
        SetTimeOfMeal(Console.ReadLine());
    }

    public abstract string AddToList();
    public abstract int TrackCalories();
}