abstract class SmartDevice
{
    public abstract void TurnOn();
    public void ShowStatus()
    {
        Console.WriteLine("Device ststus: Active");
    }

}
interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}
class SmartLight: SmartDevice,IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Light turned on");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Lights do not support volume control");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Lights do not support volume control");
    }
}
class SmartSpeaker : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Speaker turned on");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Volume increased");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Volume decreased");
    }
}

class Program
{
    public static void Main()
    {
        SmartDevice light = new SmartLight();
        light.TurnOn();
        light.ShowStatus();
        Console.WriteLine();

        SmartDevice speaker = new SmartSpeaker();
        speaker.TurnOn();
        speaker.ShowStatus();
        Console.WriteLine();

        IRemoteControl remoteControlLight = new SmartLight();
        remoteControlLight.IncreaseVolume();
        remoteControlLight.DecreaseVolume();
        Console.WriteLine();

        IRemoteControl remortControlSpeaker = new SmartSpeaker();
        remortControlSpeaker.IncreaseVolume();
        remortControlSpeaker.DecreaseVolume();

    }
}
