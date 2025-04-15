using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running();
        running.SetDate("2025-04-17");
        running.SetLength(60);
        running.SetDistance(50);
        Cycling cycling = new Cycling();
        cycling.SetDate("2025-04-17");
        cycling.SetLength(30);
        cycling.SetDistance(120);

        Swimming swimming = new Swimming();
        swimming.SetDate("2025-04-17");
        swimming.SetLength(45);
        swimming.SetNumberofLaps(4);

        DisplayExerciseInformation(running);
        DisplayExerciseInformation(cycling);
        DisplayExerciseInformation(swimming);

        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(running);
        exercises.Add(cycling);
        exercises.Add(swimming);

        foreach (Exercise exercise in exercises)
        {
            string information = exercise.GetSummary();
        
        }

    }
    public static void DisplayExerciseInformation(Exercise exercise)
    {
        Console.WriteLine(exercise.GetSummary());
    }


}