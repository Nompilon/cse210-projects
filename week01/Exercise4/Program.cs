using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int item = -1;


        while (item != 0)
        {
            Console.WriteLine("Enter a number (use 0 to quit):");

            string clientResponse = Console.ReadLine();
            item = int.Parse(clientResponse);

            if (item != 0)
            {
                numbers.Add(item);
            }
            // for part 1, to calculate the sum
            // use the foreach function
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The total is {sum}");
        // to calculate the average, use the sum from part one
        // the average can be an inter of float
        // so we use float

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of your numbers is: {average}");

        // Part 3 to find the max

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }


}