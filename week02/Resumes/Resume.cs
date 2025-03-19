public class Resume
{
    // The C# convention is to start member variables with an underscore _
    public string _givenName;
    public List<Job> _jobs = new List<Job>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public void Display()
    {
        Console.WriteLine($"Name: {_givenName}");
        Console.WriteLine("Employment History:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}