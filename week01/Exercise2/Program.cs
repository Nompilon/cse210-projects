using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        String answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";
        string comment = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        if (grade >= 70)
        {
            comment = "Congradulations, you have passed!";
        }
        else
        {
            comment = "Your mark is below the bar. You can try again next term!";
        }
        Console.WriteLine($"{comment}");
    }
}