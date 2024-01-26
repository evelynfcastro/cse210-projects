using System;

class Program
{
    static void Main(string[] args)
    {
       Reference reference1 = new Reference("1 nephi",3,7 );
       Console.WriteLine(reference1.GetDisplayText());
       string text= "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
       Scripture newverse = new Scripture(reference1, text);

        Console.WriteLine($"Scripture Reference: {reference1}");
        Console.WriteLine($"The verse is: {text}");
        Console.WriteLine("Press Enter to hide words:");
        Console.WriteLine("Please enter the level  :(Ex: 0.1, 0.2, 0.3, etc)");
        String level = Console.ReadLine();
        double levelDouble = double.Parse(level);
     while (true)
        {
            Console.ReadLine();
            newverse.HiddenRandomWords(levelDouble);

            Console.WriteLine(newverse.GetDisplayText());

            // Check if all words are hidden, exit the loop if true
            if (newverse.IsCompletlyHidden())
            {
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    
    
    }
       


        }

