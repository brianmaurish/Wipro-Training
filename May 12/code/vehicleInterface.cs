using System.Security.Cryptography.X509Certificates;

abstract class Vehicle
{
    public string Brand;
    public int Year;

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }
    public abstract void Start();
}
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting with the key");
    }
}
class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting with the kick");
    }
}
class Program
{
    public static void Main()
    {
        Car car = new Car();
        car.Brand = "Audi";
        car.Year = 2021;
        car.DisplayInfo();
        car.Start();
    }
}