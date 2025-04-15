public abstract class Exercise
{
    protected string _date;
    protected float _length; // in minutes

    public Exercise()
    {

    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public float GetLength()
    {
        return _length;
    }

    public void SetLength(float length)
    {
        _length = length;
    }
    public abstract string GetSummary();
    
     protected string FormatDate()
    {
        if (DateTime.TryParse(_date, out DateTime parsedDate))
        {
            return parsedDate.ToString("dd MMM yyyy");
        }
        return _date;
    }
}