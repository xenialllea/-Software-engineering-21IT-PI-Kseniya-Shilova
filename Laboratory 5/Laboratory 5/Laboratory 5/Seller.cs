namespace Laboratory_5;

public class Seller
{
    public void Sale(string product, Buyer buyer)
    {
        if (string.IsNullOrEmpty(product))
            throw new ArgumentNullException(null, "Вы ничего не купили,выберите продукт");

        if (string.Compare(product, "Алкоголь", StringComparison.Ordinal) == 0 && buyer.Age < 18)
        {
            throw new SaleProhibitedException(Convert.ToString(buyer.Age));
        }
        else
        {
            Console.WriteLine("Товар продан");
        }
    }
}