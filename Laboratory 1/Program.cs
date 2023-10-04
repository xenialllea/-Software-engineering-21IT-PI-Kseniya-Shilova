// See https://aka.ms/new-console-template for more information

namespace Laboratory_1;

public abstract class ItemBase
{
    public decimal Price { get; set; }
    public string Manufacturer { get; set; }
}

public class Copybook : ItemBase
{
    public string LineType { get; set; }
    public int ListCount { get; set; }

    public Copybook(decimal price, string manufacturer, string lineType, int listCount)
    {
        Price = price;
        Manufacturer = manufacturer;
        LineType = lineType;
        ListCount = listCount;
    }
    
}

public abstract class WritingDevicesBase : ItemBase
{
    public string LineColor { get; set; }
    
    
}

interface IChangebleLineHeight
{
    public float LineHeight { get; set; }
}


public class GelPen : WritingDevicesBase, IChangebleLineHeight
{
    public byte GelWight { get; set; }
    public float LineHeight { get; set; }

    public GelPen(decimal price, string manufacturer, string lineColor, byte gelWight,float lineHeight)
    {
        Price = price;
        Manufacturer = manufacturer;
        LineColor = lineColor;
        GelWight = gelWight;
        LineHeight = lineHeight;
    }
}

public class BallPointPen : WritingDevicesBase, IChangebleLineHeight
{
    public Boolean IsChangebleRod { get; set; }
    public float LineHeight { get; set; }
}

public class Pensil : WritingDevicesBase
{
    public string Hardness { get; set; }
    public float Width { get; set; }

    public Pensil(decimal price, string manufacturer, string lineColor, string hardness, float width)
    {
        Price = price;
        Manufacturer =manufacturer;
        LineColor = lineColor;
        Hardness = hardness;
        Width = width;
    }
}

public class Marker : WritingDevicesBase, IChangebleLineHeight
{
   

    public float LineHeight { get; set; }
    
    
}