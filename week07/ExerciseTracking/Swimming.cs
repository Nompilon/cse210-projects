using System.Runtime.CompilerServices;

public class Swimming : Exercise
{
    private int _numberOfLaps = 0; // in minutes
    public int GetNumberOfLaps()
    {
        return _numberOfLaps;
    }
    public void SetNumberofLaps(int numberofLaps)
    {
        _numberOfLaps= numberofLaps;
    }
    public override string GetSummary()
    {
        double distance = _numberOfLaps * 50 / 1000.0; // Convert meters to kilometers
        double speed = (_length > 0) ? (distance / (_length / 60)) : 0; // km/h
        double pace = (distance > 0) ? (_length / distance) : 0; // min/km
        DateTime parsedDate = DateTime.Parse(_date);
        string formattedDate = parsedDate.ToString("dd MMM yyyy");

        return $"{formattedDate} Swimming ({_length} min): Distance {distance:F2} km, Speed: {speed:F2} kph, Pace: {pace:F2} min per km";
    }
}