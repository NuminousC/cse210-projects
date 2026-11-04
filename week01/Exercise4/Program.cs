using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an empty list to store the numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Ask the user to enter numbers
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Calculate the sum
        int sum = 0;

        foreach (int item in numbers)
        {
            sum += item;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        int largest = numbers[0];

        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");
    }
}
