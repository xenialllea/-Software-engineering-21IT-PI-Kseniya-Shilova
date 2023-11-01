namespace Laboratory_work_3;

public class PhotoStudio<T> where T : Order
{
  public List<T> Orders { get; set; }
  
  public PhotoStudio(List<T> orders)
  {
    if (orders == null || orders.Count == 0)
      throw new ArgumentException(null, nameof(orders));
    Orders = orders;
  }

  public void PrintTheCalculation()
  {
    foreach (var element in Orders)
    {
      Console.WriteLine($"Номер заказа: {element.OrderNumber} и его суммарная стоимость {element.PhotoList.Sum(photo =>photo.Price)} рублей" );
    }
  }
}
// 