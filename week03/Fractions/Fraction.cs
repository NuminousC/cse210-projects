
public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor 1: Creates 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: Creates a fraction with the given top and 1 at the bottom
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Creates a fraction using the given top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Changes the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // Retrieves the top number
    public int GetTop()
    {
        return _top;
    }

    // Changes the bottom number
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Retrieves the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // Returns the fraction as text
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
