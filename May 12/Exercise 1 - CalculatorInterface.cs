interface ICalculator
{
    void Add(int num1, int num2);
    void Subtract(int num1, int num2);
    void Multiply(int num1, int num2);
    void Divide(int num1, int num2);
}
class SimpleCalculator : ICalculator
{
    public void Add(int a,int b)
    {
        Console.WriteLine("The addition of "+a+" and "+b+" is: "+(a+b));
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine("The subtraction of " + a + " and " + b + " is: " + (a - b));
    }
    public void Multiply(int a, int b)
    {
        Console.WriteLine("The multiplication of " + a + " and " + b + " is: " + (a * b));
    }
    public void Divide(int a, int b)
    {
        Console.WriteLine("The division of " + a + " and " + b + " is: " + ((double) a / b));
    }
}
class Program
{
    public static void Main()
    {
        SimpleCalculator calculate = new SimpleCalculator();
        calculate.Add(1, 2);
        calculate.Subtract(1, 2);
        calculate.Multiply(1, 2);
        calculate.Divide(1, 2);
    }
}