using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ')
                    .Select(word => new Word(word))
                    .ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(reference);
        foreach (var word in words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }

    public void HideRandomWord()
    {
        var visibleWords = words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            Random rand = new Random();
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden);
    }
}

class Word
{
    private string text;
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        this.text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string GetDisplayText()
    {
        return IsHidden ? new string('_', text.Length) : text;
    }
}

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16",
            "For God so loved the world that he gave his one and only Son, " +
            "that whoever believes in him shall not perish but have eternal life.");

        Console.Clear();
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            Console.Clear();
            scripture.HideRandomWord();
            scripture.DisplayScripture();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations, you have memorized the scripture!");
                break;
            }
        }
    }
}