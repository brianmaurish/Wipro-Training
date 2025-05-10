using System.Net.Mail;

class Payment
{
    public decimal Amount;
    public string Currency;

    public virtual void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Processing Amount: " + Amount);
    }
    public virtual void ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine("Processing Amount: "+Amount);
        Console.WriteLine("Processing Currency: " + Currency);
    }
}
class CreditCardPayment : Payment
{
    public int CardNumber;
    public void ShowDetails()
    {
        Console.WriteLine("CardNumber: " + CardNumber);
    }
}
class PayPalPayment : Payment
{
    public string EmailAddress;
    
    public void ShowDetails()
    {
        Console.WriteLine("Email: "+EmailAddress);
    }
}
class Program
{
    public static void Main()
    {
        CreditCardPayment payment1 = new CreditCardPayment();
        payment1.CardNumber = 123456;
        payment1.ProcessPayment(2100);
        payment1.ProcessPayment(3000,"$3600");
        payment1.ShowDetails();

        PayPalPayment payment2 = new PayPalPayment();
        payment2.EmailAddress = "email@gmail.com";
        payment2.ProcessPayment(2100);
        payment2.ProcessPayment(3000, "$3600");
        payment2.ShowDetails();



    }
}