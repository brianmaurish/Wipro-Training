abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public int RatePerDay { get; set; }
    public virtual int CalculateRent(int days)
    {
        return RatePerDay * days;
    }

}
class Car: Vehicle
{
    public override int CalculateRent(int days)
    {
        int surcharge=200;
        return base.CalculateRent(days) + surcharge; 
    }
}
class Bike : Vehicle
{
    public override int CalculateRent(int days)
    {
        int surcharge = 50;
        return base.CalculateRent(days) + surcharge;
    }
}
class Truck : Vehicle
{
    public override int CalculateRent(int days)
    {
        int surcharge = 250;
        return base.CalculateRent(days) + surcharge;
    }
}
class Program
{
    public static void Main()
    {
        List<Vehicle> list = new List<Vehicle>();
        {
            list.Add(new Car { VehicleNumber = "B123", Brand = "Toyota", RatePerDay = 1500 });
            list.Add(new Bike { VehicleNumber = "C456", Brand = "Yamaha", RatePerDay = 500 });
            list.Add(new Truck { VehicleNumber = "D234", Brand = "Volvo", RatePerDay = 2500 });

            int rentalDays = 5;

            foreach(Vehicle v in list)
            {
                Console.WriteLine("Vehicle: " + v.Brand + " " + v.VehicleNumber);
                Console.WriteLine("Rent for 5 days: " + v.CalculateRent(rentalDays));
                Console.WriteLine();
            }
        }
    }
}