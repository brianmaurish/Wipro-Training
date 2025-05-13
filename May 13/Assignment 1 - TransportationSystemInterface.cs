using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

interface ITransport
{
    void start();
    void stop();
}
class Bus: ITransport
{
    public void start()
    {
        Console.WriteLine("Bus is starting");
    }
    public void stop()
    {
        Console.WriteLine("Bus is stopping");
    }
}
class Train : ITransport
{
    public void start()
    {
        Console.WriteLine("Train is starting");
    }
    public void stop()
    {
        Console.WriteLine("Train is stopping");
    }
}
class Program
{
    static void Main()
    {
        ITransport transport = new Bus();
        transport.start();
        transport.stop();

        transport=new Train();
        transport.start();
        transport.stop();
    }

}




