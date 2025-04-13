public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public virtual string GetDetailsString()
    {
        return ($"{_shortName} ({_description})- {_points} points");
    }

    public abstract bool IsComplete();


    public abstract string GetStringRepresentation();

    
}