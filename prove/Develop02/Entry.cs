using System.Runtime.CompilerServices;

class Entry
{
 public DateTime Date { get; }
    public string Prompt { get; }
    public string Content { get; set; }

    public Entry(DateTime date, string prompt)
    {
        Date = date;
        Prompt = prompt;
        Content = "";
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}, Prompt: {Prompt}");
        Console.WriteLine($"Content: {Content}");
    }
}