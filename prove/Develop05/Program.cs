using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Progress: ");
for (int i = 0; i <= 100; i += 5)
{
    Console.Write($"[{i}%]");
    Thread.Sleep(100);
    Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);
}
}
    }
