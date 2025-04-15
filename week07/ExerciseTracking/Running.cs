public class Running : Exercise
{
    private double _distance = 0;

    private double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        double speed = (_length > 0) ? (_distance / (_length / 60)) : 0; // Kph
        double pace = (_distance > 0) ? (_length / _distance) : 0; // min per Km
        
        return $"{FormatDate()} Running ({_length} min) - Distance: {_distance:F1} Km, Speed: {speed:F1} Kph, Pace: {pace:F1} min per Km";
    }
}