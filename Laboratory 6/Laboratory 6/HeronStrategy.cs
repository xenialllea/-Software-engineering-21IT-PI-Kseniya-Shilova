namespace Laboratory_6;

public class HeronStrategy : IStrategy
{
    public double GetArea(double a, double b, double c)
    {
        var p = (a + b + c) / 2;
        Console.WriteLine("Using Heron Formula Strategy ");
        return  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}