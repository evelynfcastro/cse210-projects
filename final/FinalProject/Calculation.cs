using System.Security.Cryptography;

public class Calculation
{
 private int _weight;
 private int _age;
 private double _hight;

public void CalculationCalories()
{
  
  
  Console.WriteLine("Enter your Age:");
        string  age =Console.ReadLine();
        _age = int.Parse(age);
    
        Console.WriteLine("Enter your Hight:(in cm)");
        string hight = Console.ReadLine();
         _hight= double.Parse(hight);
        Console.WriteLine("Enter YOur Weight: (in Klg)");
        string weight =Console.ReadLine();
        _weight = int.Parse(weight);   
        Console.WriteLine("Enter your Gender: (M/F);");
        string userGender = Console.ReadLine();
        if (userGender == "F")
        {
            double calculation = 655 + (9.6 * _weight ) + (1.8 * _hight) - (4.7 * _age);
        Console.WriteLine($"Your kalories amount per day should be: {calculation}");

        }
        else if (userGender == "M")
        {
            double calculation = 66 + (13.7 * _weight) + (5 * _hight) - (6.8 *+ _age);
        Console.WriteLine($"Your kalories amount per day should be: {calculation}");
        }
         
}

       
}