namespace Laboratory_1;

public abstract class Program
{
    
    public static void Main(string[] args)
    
    {
        //Создадим несколько экземпляров различных классов- товаров
        Copybook copybook = new Copybook(20, "ЯЖТетрадь", "vKletochku", 20);
        Pensil pensil = new Pensil(100, "Brauberg", "red", "HB", 12f);
        GelPen pen1 = new GelPen(100, "Brauberg", "black", 20, 0.5f);
        GelPen pen2 = new GelPen(100, "Brauberg", "black", 20, 0.5f);
        //Добавим их в лист типа ItemBase
        List<ItemBase> items = new List<ItemBase>() 
        { 
            pen1, pen2,pensil, copybook
        };
        //Теперь пробежимся по листу элементов при помощи цикла и проверим, возможно ли выявить письменные пренодлежности 
        foreach (var obj in items)
        {
            if (obj is WritingDevicesBase)
            {
                Console.WriteLine("Этим явно можно писать " + obj.Price);
            }
            else
            {
                Console.WriteLine("А этим писать не получится " + obj.Price);
            }
        }
        
    }
}