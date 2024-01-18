namespace Laboratory_6;

internal static class Program
{
    private static void Main(string[] args)
    {
        var rightTriangle= new Triangle(13,5,12);
        Console.WriteLine(rightTriangle.GetArea());
        
        var anyTriangle= new Triangle(7, 4, 5);
        Console.WriteLine(anyTriangle.GetArea());
        
        var changeableTriangle= new Triangle(3, 4, 5);
        changeableTriangle.SecondSide = 5;
        Console.WriteLine(changeableTriangle.GetArea());
        
        var nonexistentTriangle= new Triangle(7, 1, 5);
        Console.WriteLine(nonexistentTriangle.GetArea());
    }
}