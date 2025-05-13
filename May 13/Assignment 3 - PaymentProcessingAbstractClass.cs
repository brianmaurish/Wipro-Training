using System.Security.Cryptography.X509Certificates;

abstract class PaymentGateway
{
    public abstract void ProcessPayment(double amount);
    public void ShowGatewayName()
    {
        Console.WriteLine("Processing payment through gateway");
    }

}
class StripeGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment through Stripe: "+amount);
    }
}
class PayPalGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment through PayPal: " + amount);
    }
}

class Program
{
    public static void Main()
    {
        PaymentGateway paymentGateway = new StripeGateway();
        paymentGateway.ShowGatewayName();
        paymentGateway.ProcessPayment(12000);

        paymentGateway = new PayPalGateway();
        paymentGateway.ShowGatewayName();
        paymentGateway.ProcessPayment(32500);

    }
}