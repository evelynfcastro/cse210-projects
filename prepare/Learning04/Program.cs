using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Assignments assignment1 = new Assignments("Evelyn", "Abstraction");
        Console.WriteLine(assignment1.GetSummary());
        Mathassignments assignment2 = new Mathassignments("Emilly Roberts", "Functions","6.9","1-3");
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("John Davis", "Brazil History", "Dom Peter II");
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}