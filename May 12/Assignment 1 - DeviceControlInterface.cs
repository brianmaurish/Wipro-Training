using System.Security.Cryptography.X509Certificates;

interface IDeviceControl
{
    void TurnOn();
    void TurnOff();

}
class SmartTV : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("SmartTV is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("SmartTV is now OFF");
    }

}
class Speaker : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("Speaker is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("Speaker is now OFF");
    }

}

class Program
{
    public static void Main()
    {
        SmartTV tv = new SmartTV();
        tv.TurnOn();
        tv.TurnOff();

        Speaker speaker = new Speaker();
        speaker.TurnOn();
        speaker.TurnOff();
    }
}