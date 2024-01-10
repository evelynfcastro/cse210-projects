using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome(); 
       string name= PromptUserName();
       int number = PromptUserNumber();
       int square= SquareNumber(number);
       DisplayResult(name,square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        Console.Write("Please, enter your name:");
        string usarName = Console.ReadLine();
        return usarName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please, enter your favorite number: ");
        int userNumber= int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int Square= userNumber*userNumber;
        return Square;
    }
    static void DisplayResult (string name, int numberSquare)
    {
        Console.WriteLine($"{name} the square of your number is {numberSquare}");
    }
}