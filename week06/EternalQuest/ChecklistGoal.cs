public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int amountCompleted, int target, int bonus)
    : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine("Event recorded successfully!");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Wow, congratulations! You completed the checklist goal and earned a bonus of {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }


    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - {_points} points -- Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
