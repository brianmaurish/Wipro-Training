class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Working");
    }
}
class WashingMachine:Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washinng clothes");
    }
}

class Program
{
    public static void Main()
    {
        Appliance appliance = new Appliance();
        WashingMachine washing = new WashingMachine();

        appliance.Operate();
        washing.Operate();
    }
}