using System;
public class PromptGenerator
{public List<string> Prompts {get; set;}
//Create a list of strings 
    public PromptGenerator()


    {
        Prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today",
            "How did I see the hand of the Lord in my life today?",
            "If I had one thing I could do over today, what would it be?",
            "What are you grateful for today? ",
            "What are you praying for today? ",
            "What did I learn today?",
            "What emotions did I experience and why?",
            "What am I praying for today?",
            "What is yoir verse of the day?",
            "What is today's Affirmation?"
        };
    }

    //Create an instance of Random 
    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        //Select and return the random string 
        return Prompts[index];
    }

}


        

    
        
    



