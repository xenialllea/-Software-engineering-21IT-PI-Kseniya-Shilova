namespace Laboratory_4;

public class ShoppingList:List<Bread>
{
    public IEnumerable<Bread> SortFirstClassFlourByPrice()
    {
        return this.Where(x => x.FlourGrade == "Первый").OrderBy(x => x.Price);
    }
}