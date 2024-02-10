using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Press any key to start the confetti animation...");
        Console.ReadKey();

        Console.CursorVisible = false;

        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            int left = random.Next(Console.WindowWidth);
            int top = random.Next(Console.WindowHeight / 2);

            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);

            Console.Write("*");

            Thread.Sleep(50); // Adjust the sleep duration for the desired animation speed
        }

        Console.ResetColor();
        Console.Clear();
        Console.WriteLine("Animation complete!");
    }
    }
