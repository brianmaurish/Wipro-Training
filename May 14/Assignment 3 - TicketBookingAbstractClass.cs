using System.Security.Cryptography.X509Certificates;

abstract class TicketBooking
{
    public abstract void BookTicket(int seats);
    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking tickets");
    }

}
class BusBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} bus ticket");
    }
}
class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} flight ticket");
    }
}

class Program
{
    public static void Main()
    {
        TicketBooking bus= new BusBooking();
        bus.ShowBookingInfo();
        bus.BookTicket(1);

        TicketBooking flight= new FlightBooking();
        flight.ShowBookingInfo();
        flight.BookTicket(2);

    }
}