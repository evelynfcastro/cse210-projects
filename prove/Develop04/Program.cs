using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity();
        string choice;

        while (true)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Breath Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select an option from the menu:");

            choice = Console.ReadLine();
            activity1.SetUserChoice(choice);

            if (choice == "5")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break; // Exit the loop and end the program
            }

            Console.WriteLine("How long in seconds would you like for your session?");
            string timeInput = Console.ReadLine();

            if (int.TryParse(timeInput, out int intValue))
            {
                activity1.SetTime(intValue);
                Thread.Sleep(2000);
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathingActivity1 = new BreathingActivity();
                        breathingActivity1.Run(activity1.GetUSerTime());
                        break;
                    case "2":
                        ListingActivity listingActivity1 = new ListingActivity();
                        listingActivity1.Ran(activity1.GetUSerTime());
                        break;
                    case "3":
                        ReflectingActivity reflectingActivity1 = new ReflectingActivity();
                        reflectingActivity1.Run(activity1.GetUSerTime());
                        break;
                    case "4":
                        GratitudeActivity gratitudeActivity1 = new GratitudeActivity();
                        gratitudeActivity1.Run(activity1.GetUSerTime());
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid time input. Please enter a valid number.");
            }
    }
    }
}