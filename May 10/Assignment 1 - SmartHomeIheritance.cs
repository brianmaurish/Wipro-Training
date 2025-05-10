class SmartDevice
{
    public string DeviceName;
    public bool PowerStatus;

    public SmartDevice(string DeviceName,bool PowerStatus)
    {
        this.DeviceName = DeviceName;
        this.PowerStatus = PowerStatus;
    }
        
    public void TogglePower()
    {
        if(PowerStatus)
        {
            PowerStatus = false;
            Console.WriteLine("Power is: OFF");
        }
        else
        {
            PowerStatus = true;
            Console.WriteLine("Power Status: ON" );
        }
    }
}
class SmartLight : SmartDevice
{
    int Brightness;
    public SmartLight(string devicename, bool powerstatus ) : base(devicename, powerstatus) { }
    public void SetBrightness(int  value)
   {
        Brightness = value;
    }
    public void ShowStatus()
    {
        Console.WriteLine("The device name: " + DeviceName);
        if (PowerStatus)
            Console.WriteLine("Power is ON");
        else
            Console.WriteLine("Power is OFF");

        Console.WriteLine("The Brightness is: " + Brightness);
    }
}
class SmartThermostat:SmartDevice
{
    double Temperature;
    public SmartThermostat(string devicename, bool powerstatus) : base(devicename, powerstatus) { }
    public void SetTemperature(int value)
    {
        Temperature = value;
    }
    public void ShowStatus()
    {
        Console.WriteLine("The device name: " + DeviceName);
        if (PowerStatus)
            Console.WriteLine("Power is ON");
        else
            Console.WriteLine("Power is OFF");

        Console.WriteLine("The Temperature is: " + Temperature);
    }
}

class Program
{
    public static void Main()
    {
        SmartDevice device = new SmartDevice("Television",true);
        device.TogglePower();

        SmartLight brightness=new SmartLight("Living Room Light",true);
        brightness.SetBrightness(25);
        brightness.ShowStatus();

        SmartThermostat temp = new SmartThermostat("Kitchen Thermostat",true);
        temp.SetTemperature(35);
        temp.ShowStatus();

    }
}