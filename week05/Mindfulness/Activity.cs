public class Activity
{
    protected string _StartingMessage;
    protected string _EndingMessage;
    protected int _Spinner;
    protected int _CountDown;

    public Activity(string startingMessage, string endingMessage, int countDown, int spinner)
    {
        _StartingMessage = startingMessage;
        _EndingMessage = endingMessage;
        _Spinner = spinner;
        _CountDown = countDown;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_StartingMessage}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"{_EndingMessage}");
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++) // 4 frames per second
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250); // 250ms per frame
            Console.Write("\b"); // Erase character
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // Waits for 1 second
        }
        Console.WriteLine();
    }


}