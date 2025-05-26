interface IPaymentProcessor
{
    void ProcessPayment();
}
abstract class PaymentGateway
{
    public string GatewayName { get; set; }
    public PaymentGateway(string gatewayName)
    {
        GatewayName = gatewayName;
    }
    public virtual bool Validate()
    {
        Console.WriteLine($"{GatewayName} gateway validated successfully");
        return true;
    }

}
class Razorpay:PaymentGateway, IPaymentProcessor
{
    public Razorpay(): base("Razorpay") { }
    public void ProcessPayment()
    {
        if(Validate())
        {
            Console.WriteLine("Processing payment through Razorpay");
        }
    }
}
class PayPal : PaymentGateway, IPaymentProcessor
{
    public PayPal() : base("PayPay") { }
    public void ProcessPayment()
    {
        if (Validate())
        {
            Console.WriteLine("Processing payment through PayPay");
        }
    }
}
class Stripe : PaymentGateway, IPaymentProcessor
{
    public Stripe() : base("Stripe") { }
    public void ProcessPayment()
    {
        if (Validate())
        {
            Console.WriteLine("Processing payment through Stripe");
        }
    }
}
class Program
{ 
    static void Main()
    {
        Razorpay razorpay = new Razorpay();
        razorpay.ProcessPayment();
        Console.WriteLine();

        PayPal payPal = new PayPal();
        payPal.ProcessPayment();
        Console.WriteLine() ;

        Stripe stripe = new Stripe();
        stripe.ProcessPayment();

    }
}