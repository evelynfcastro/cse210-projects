using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
         Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

           while (true)
        {
            Console.WriteLine("Welcome to Journal Program!!!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");

             int choice = int.Parse(Console.ReadLine());

            
            switch (choice)
            {
                case 1:

                    string prompt2 = promptGenerator.GetRandomPrompt() ;
                    Console.WriteLine(prompt2);
                    string content = Console.ReadLine();
                    Entry newEntry = new Entry(DateTime.Now, prompt2) { Content = content };
                    myJournal.AddEntry(newEntry);
                    break;

                 case 2:
                    myJournal.DisplayAll();
                    break;

                case 3:
                    Console.WriteLine("Enter file path to save:");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    break;

                case 4:
                    Console.WriteLine("Enter file path to load:");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}




  