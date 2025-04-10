using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
     {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference,"For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life.");

        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            Console.Clear();
            scripture.HideRandomWords(1);
            scripture.GetDisplayText();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations, you have memorized the scripture!");
                break;
            }
        }

    }
}