using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeNum = int.Parse(grade);
        string letter = "";

        if (gradeNum >= 90)
        {
            letter="A";
        }
        else if (gradeNum >= 80)
        {
            letter="B";
        }
        else if (gradeNum >= 70)
        {
            letter= "C";
        }
        else if (gradeNum >= 60)
        {
            letter= "D";
        }
        else if (gradeNum < 60)
        {
            letter="F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (gradeNum>= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass, try next semester.");
        }
    }
}