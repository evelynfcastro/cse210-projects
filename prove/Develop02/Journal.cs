using System;
using System.Collections.Generic;
using System.IO;

class Journal
{  private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date};{entry.Prompt};{entry.Content}");
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
         if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
            string fileContent = reader.ReadToEnd();

                // Display the content (you can process or manipulate it as needed)
                Console.WriteLine("File Content:");
                Console.WriteLine(fileContent);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}