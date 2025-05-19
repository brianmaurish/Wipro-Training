
    public abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);

        public void ShowPaymentMethod()
        {
            Console.WriteLine("Payment Method: " + this.GetType().Name);
        }
    }

    public class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
    }
    }

    public class UPIPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount}");
    }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod payment1 = new CreditCardPayment();
            PaymentMethod payment2 = new UPIPayment();

            payment1.ShowPaymentMethod();
            payment1.ProcessPayment(1500.50m);
            Console.WriteLine();

            payment2.ShowPaymentMethod();
            payment2.ProcessPayment(500.75m);
            Console.WriteLine();

            PaymentMethod payment3 = new CreditCardPayment();
            payment3.ProcessPayment(2000.00m); // Will call CreditCardPayment's method
            Console.WriteLine();

            PaymentMethod payment4 = new UPIPayment();
            payment4.ProcessPayment(1200.00m); // Will call UPIPayment's method
        }
    }

