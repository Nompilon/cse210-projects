class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _userResponses = new List<string>();
    public ListingActivity()
    : base("Hello, Welcome to the Listing activity!", "Goodbye, thank you for participating; press enter to play again!", 3, 3)
    {

    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        return _userResponses;
    }
    public void Run()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        Console.WriteLine("Let's begin the exercise...\n");

        Console.WriteLine("You will be shown a prompt. When you are ready, start listing items that come to mind.");
        Console.WriteLine("You have 45 seconds.");
        ShowSpinner(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("Start listing items. Press Enter after each:");

        DateTime endTime = DateTime.Now.AddSeconds(45);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _userResponses.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {_userResponses.Count} items.");
        ShowSpinner(_Spinner);
    }
    

}

