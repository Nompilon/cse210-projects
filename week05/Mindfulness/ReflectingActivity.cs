using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    : base("Hello, Welcome to the Reflecting activity!", "Goodbye, thank you for participating; press enter to play again!", 2, 1)
    {

    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void Displayprompt()
    {
        Console.WriteLine($"{_prompts}");
    }

    public void DisplayQuestion()
    {
         Console.WriteLine($"{_questions}");
    }

    public void Run()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        Console.WriteLine("Let's begin the exercise...\n");
         ShowSpinner(_Spinner);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt:\n--- {prompt} ---");
        Console.WriteLine("\nThink deeply about this prompt...");
        ShowSpinner(_Spinner);

        Console.WriteLine("\nNow consider the following questions:");
        for (int i = 0; i < 3; i++)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinner(_Spinner);
        }

    }
}