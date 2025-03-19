public class Job
{
    // The C# convention is to start member variables with an underscore _
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}), {_startYear} - {_endYear}");
    }

}