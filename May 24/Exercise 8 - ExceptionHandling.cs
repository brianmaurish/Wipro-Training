using System.Diagnostics;

class Program
{
    static async Task RiskyTaskAsync(string name)
    {
        Console.WriteLine($"{name} is running");
        await Task.Delay(1000);

        if (name == "task 2")
        {
            throw new InvalidOperationException($"{name} encountered an error!");
        }

        Console.WriteLine($"{name} completed successfully");
    }

    static async Task Main(string[] args)
    {
        Task t1 = RiskyTaskAsync("task 1");
        Task t2 = RiskyTaskAsync("task 2"); 
        Task t3 = RiskyTaskAsync("task 3");

        try
        {
            await Task.WhenAll(t1, t2, t3);
        }
        catch (Exception)
        {
            if (t1.IsFaulted)
                Console.WriteLine($"t1 failed: {t1.Exception?.InnerException?.Message}");
            if (t2.IsFaulted)
                Console.WriteLine($"t2 failed: {t2.Exception?.InnerException?.Message}");
            if (t3.IsFaulted)
                Console.WriteLine($"t3 failed: {t3.Exception?.InnerException?.Message}");
        }
    }
}