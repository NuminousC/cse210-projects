
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create fractions using the three constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // Display the fractions and their decimal values
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // Test the setters
        fraction3.SetTop(6);
        fraction3.SetBottom(8);

        // Test the getters
        Console.WriteLine("New top: " + fraction3.GetTop());
        Console.WriteLine("New bottom: " + fraction3.GetBottom());

        // Display the updated fraction
        Console.WriteLine(fraction3.GetFractionString());
    }
}
