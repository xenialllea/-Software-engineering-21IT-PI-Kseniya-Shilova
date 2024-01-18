namespace Laboratory_6;

public class RightTriangleStrategy : IStrategy
{
    public double GetArea(double a, double b, double c)
    {
        Console.WriteLine("Using Right Triangle Strategy");
        return (a * b) / 2;
    }
}