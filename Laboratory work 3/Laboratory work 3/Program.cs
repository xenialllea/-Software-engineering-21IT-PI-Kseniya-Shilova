// See https://aka.ms/new-console-template for more information

namespace Laboratory_work_3;

class Program
{
    static void Main(string[] args)
    {
        Photo portrait = new Photo(1200);
        Photo inFullGrowth = new Photo(1500);
        Photo threeQuarters = new Photo(1300);
        Order order1 = new Order("2001", new List<Photo> { portrait, threeQuarters });
        Order order2 = new Order("2002", new List<Photo> { portrait, threeQuarters, inFullGrowth });
        PhotoStudio<Order> photoContent = new PhotoStudio<Order>(new List<Order> { order1, order2 });
        photoContent.PrintTheCalculation();
    }
}