namespace Laboratory_work_3;

public class Order
{
    public string OrderNumber { get; set; }
    public List<Photo>? PhotoList { get; set; }

    public Order(string orderNumber, List<Photo>? photoList)
    {
        if (photoList == null || photoList.Count == 0)
        {
            throw new ArgumentException(null, nameof(photoList));
        }
        else
        {
            PhotoList = photoList;
        }


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