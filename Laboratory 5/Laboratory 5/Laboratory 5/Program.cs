// See https://aka.ms/new-console-template for more information

namespace Laboratory_5;

internal class Program
{
    public static void Main()
    {
        Seller sellerOfPyaterochka = new Seller();
        Buyer bad = new Buyer(17);
        try
        {
            sellerOfPyaterochka.Sale("Алкоголь", bad);
        }
        catch (SaleProhibitedException ex)
        {
            Console.WriteLine(ex.ErrorMessage);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}