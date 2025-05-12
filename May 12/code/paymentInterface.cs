interface IPayment
{
    void ProcessPayment(decimal amount);
}
class CredictCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}
class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPalpayment of {amount}");
    }
}
class Program
{
    public static void Main()
    {
        //using the interface as a reference
        IPayment payment; 

        //credit card payment
        payment = new CredictCardPayment();
        payment.ProcessPayment(1500.50m);

        //PayPal payment
        payment = new PayPalPayment();
        payment.ProcessPayment(2500.75m);
    }
}