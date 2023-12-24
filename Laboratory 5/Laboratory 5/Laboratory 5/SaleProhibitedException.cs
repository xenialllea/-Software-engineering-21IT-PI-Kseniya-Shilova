namespace Laboratory_5;

public class SaleProhibitedException : Exception
{
    public string ErrorMessage { get; }

    public SaleProhibitedException(string age)
    {
        ErrorMessage = $"Продажа запрещена! В {age} пить алкоголь ещё нельзя,а лучше вообще не начинать.";
    }
    // public SaleProhibitedException(): base("Продажа запрещена!")
}