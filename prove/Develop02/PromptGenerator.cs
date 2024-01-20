using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
public class PromptGenerator
{
    
 private List<string> prompts = new List<string>
    {
        "Write about a memorable moment from today.",
        "Describe something you learned recently.",
        "What are your goals for tomorrow?",
        "Write about something that made you smile today.",
        "Discuss a challenge you faced and how you overcame it."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts [index];
        
    }
}
