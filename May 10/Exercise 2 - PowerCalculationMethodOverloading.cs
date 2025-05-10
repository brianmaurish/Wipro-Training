class CalculatePower
{
    public void Power(int a, int b)
    {
        Console.WriteLine("The power is: "+Math.Pow(a,b));
    }
    public void Power(double a, double b)
    {
        Console.WriteLine("The power is: " + Math.Pow(a, b));
    }
}

class Program
{
    public static void Main()
    {
        CalculatePower calculate = new CalculatePower();

        calculate.Power(2, 3);
        calculate.Power(5.5, 2);
    }
}