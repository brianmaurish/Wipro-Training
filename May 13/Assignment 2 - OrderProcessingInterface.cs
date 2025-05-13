using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

interface IOrder
{
    void PlaceOrder(string item);
    void CancelOrder(string item);
}
class DineInOrder: IOrder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine(item);
    }
    public void CancelOrder(string item)
    {
        Console.WriteLine(item);
    }
}
class TakeawayOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine(item);
    }
    public void CancelOrder(string item)
    {
        Console.WriteLine(item);
    }
}
class Program
{
    static void Main()
    {
        IOrder order = new DineInOrder();
        order.PlaceOrder("Placing dine-in order for item");
        order.CancelOrder("Canceling dine-in order for item");

        order = new TakeawayOrder();
        order.PlaceOrder("Placing takeaway order for item");
        order.CancelOrder("Canceling takeaway order for item");
    }

}




