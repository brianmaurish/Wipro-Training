using System.Security.Cryptography.X509Certificates;

abstract class FoodOrder
{
    public abstract void PlaceOrder(string item);
    public void OrderInfo()
    {
        Console.WriteLine("Placing food order");
    }

}
class FastFoodOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order placed for {item} at Fast Food Outlet");
    }
}
class FineDinnerOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order placed for {item} at Fine Dinning Restaurant");
    }
}

class Program
{
    public static void Main()
    {
        FoodOrder fastFood = new FastFoodOrder();
        fastFood.OrderInfo();
        fastFood.PlaceOrder("Butter Chicken");

        FoodOrder fineDinning = new FineDinnerOrder();
        fineDinning.OrderInfo();
        fineDinning.PlaceOrder("Veg Noodles");

    }
}