namespace Laboratory_4;

public class Bread
{
    public string FlourGrade { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Bread(string flourGrade, string name, decimal price)
    {
        if (string.IsNullOrEmpty(flourGrade))
        {
            throw new ArgumentException(null, nameof(flourGrade));
        }
        FlourGrade = flourGrade;
        
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException(null,nameof(name));
        }
        Name = name;
        
        Price = price;
    }
    
}