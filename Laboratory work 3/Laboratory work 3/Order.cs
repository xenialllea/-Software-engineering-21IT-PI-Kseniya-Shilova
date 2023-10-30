namespace Laboratory_work_3;

public class Order
{
    public string OrderNumber { get; set; }
    public List<Photo> PhotoList { get; set; }

    public Order(string orderNumber, List<Photo> photoList)
    {
        PhotoList = photoList;
    
        if (string.IsNullOrEmpty(orderNumber))
        {
            throw new ArgumentException(null, nameof(orderNumber));
        }
        else
        {
            OrderNumber = orderNumber;
        }
    }
}