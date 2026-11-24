using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the base Assignment class.
        Assignment assignment = new Assignment(
            "Samuel Bennett",
            "Multiplication");

        Console.WriteLine("BASE ASSIGNMENT");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        // Test the MathAssignment derived class.
        MathAssignment math = new MathAssignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19");

        Console.WriteLine("MATH ASSIGNMENT");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        // Test the WritingAssignment derived class.
        WritingAssignment writing = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II");

        Console.WriteLine("WRITING ASSIGNMENT");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
