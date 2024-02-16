public class Sneaks: Meal
{
public void GetSneaksInformation()
{
    GetMealInformation();

}
    public override string AddToList()
    {
        return $" Sneak {GetFoodName()} Calories: {GetFoodCalories()}";

    }
    public override int TrackCalories()
    {
        return GetFoodCalories();
    }
}