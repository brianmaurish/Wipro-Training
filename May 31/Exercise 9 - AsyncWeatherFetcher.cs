using System.Diagnostics;

class Program
{
    static async Task WeatherFetcher(string city, int delay)
    {
        Console.WriteLine("Fetching weather for: " + city);
        await Task.Delay(delay);
        Console.WriteLine(city + " weather fetched");
    }
    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        Task city1= WeatherFetcher("Chennai", 1000);
        Task city2= WeatherFetcher("Banglore", 2000);
        Task city3= WeatherFetcher("Mumbai", 500);

        await Task.WhenAll(city1, city2, city3);

        stopwatch.Stop();
        Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds} ms");
    }
}