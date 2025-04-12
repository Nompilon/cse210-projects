public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Hello, Welcome to the Breathing activity!", "Goodbye, thank you for participating; press enter to play again!", 5, 5)
    {

    }
    public void Run()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        Console.WriteLine("Let's begin the breathing exercise...\n");
        for (int i = 0; i < (3); i++)

        {
            Console.WriteLine("Breathe in with your mouth...");
            ShowCountDown(_CountDown);
            Console.WriteLine("Hold it in..");
            ShowSpinner(_Spinner);
            Console.WriteLine("With your nose breathe out...");
            ShowCountDown(_CountDown);
            Console.WriteLine();

        }
    }

}