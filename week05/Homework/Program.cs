using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Okuhle", "Graphs");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Okuhle", "Quadratics", " 3.4", "1 - 9");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworklist());

        WritingAssignment assignment3 = new WritingAssignment("Ruth", "Essay writing", "The day I will nenver forget"); ;
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}

