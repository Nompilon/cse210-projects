public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.\n");
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the above menu: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    Console.Write("Enter filename to save: ");
                    SaveGoals(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Enter filename to load: ");
                    LoadGoals(Console.ReadLine());
                    break;
                case 5:
                    ListGoals();
                    Console.Write("Enter goal number to record: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    RecordEvent(index);
                    break;
                case 6:
                    return;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter short name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        string points = Console.ReadLine();

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case 3:
                Console.Write("Enter amount completed: ");
                int amountCompleted = int.Parse(Console.ReadLine());
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, amountCompleted, target, bonus));
                break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }
    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            if (int.TryParse(_goals[goalIndex].GetStringRepresentation().Split(',')[2], out int points))
            {
                _score += points;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    //public void DisplayScore()
    //{
    //Console.WriteLine($"You have {_score} points.");
    // }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string goalType = parts[0];
            string[] values = parts[1].Split(',');

            switch (goalType)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(values[0], values[1], values[2]));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(values[0], values[1], values[2]));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(values[0], values[1], values[2],
                        int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])));
                    break;
            }
        }
    }
}