using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 15);
        int guess = 0;

        while (guess != number)
        {
            Console.WriteLine("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Wow, you have guessed the magic number!");
            }
        }

    }



}