interface ISupportTicket
{
    void CreateTicket(string issue);
    void ResolveTicket(int ticketID);
}
class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine("Creating ticket via Email: "+issue);
    }
    public void ResolveTicket(int ticketID)
    {
        Console.WriteLine("Resolving ticket "+ ticketID +" via Email");
    }
}
class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine("Creating ticket via Phone: " + issue);
    }
    public void ResolveTicket(int ticketID)
    {
        Console.WriteLine("Resolving ticket " + ticketID + " via Phone");
    }
}
class Program
{
    static void Main()
    {
        ISupportTicket email = new EmailSupport();
        email.CreateTicket("System issue");
        email.ResolveTicket(234);

        ISupportTicket phone = new PhoneSupport();
        phone.CreateTicket("Network issue");
        phone.ResolveTicket(564);

    }

}
