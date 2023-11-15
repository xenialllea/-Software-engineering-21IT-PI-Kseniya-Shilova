// See https://aka.ms/new-console-template for more information

using Laboratory_4;

internal class Program
{
    static void Main(string[] args)
    {
        Bread whiteBread = new Bread("Первый", "White", 10);
        Bread pitaBread = new Bread("Первый", "Pita", 20);
        Bread ryeBread = new Bread("Сеяная", "Rye", 15);
        Bread wholeGrainBread = new Bread("Обойная", "wholeGrain", 10);
        Bread frenchBread = new Bread("Первый", "frenchBread", 25);
        var buySomeBread = new ShoppingList { whiteBread, pitaBread, ryeBread, wholeGrainBread, frenchBread };
        foreach (var bread in buySomeBread.SortFirstClassFlourByPrice())
        {
            Console.WriteLine($"Name of bread:{bread.Name} {bread.Price} ");
        }
    }
}
