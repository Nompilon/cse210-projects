using System;
using System.Collections.Generic;
using System.Threading;
class Program
{
    static void Main(string[] args)

    {
        bool running = true;

        while (running)
        {
            Console.Clear(); // Clears the console for a clean menu
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity activity1 = new BreathingActivity();
                    activity1.DisplayStartingMessage();
                    activity1.Run();
                    activity1.DisplayEndingMessage();

                    break;
                case "2":
                    ListingActivity activity2 = new ListingActivity();
                    activity2.DisplayStartingMessage();
                    activity2.Run();
                    activity2.DisplayEndingMessage();
                    break;

                case "3":
                    ReflectingActivity activity3 = new ReflectingActivity();
                    activity3.DisplayStartingMessage();
                    activity3.Run();
                    activity3.DisplayEndingMessage();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine(); // Pause before returning to menu
            }
        }
    }
}
