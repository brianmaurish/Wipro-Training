class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Work started");
        await DoAsyncWork();

        Console.WriteLine("Work completed");
    }
    static async Task DoAsyncWork()
    {
        Console.WriteLine("Working asyncgronously...");
        await Task.Delay(2000);
        Console.WriteLine("Async work done");
    }
}