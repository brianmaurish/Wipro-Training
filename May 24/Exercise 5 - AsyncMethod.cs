class Program
{
    static async Task<string> GetTemperatureAsync(string city)
    {
        await Task.Delay(1000);
        Random rand = new Random();
        int temperature = rand.Next(20, 40); 
        return $"{city} temperature - {temperature}°C";
    }

    static async Task Main(string[] args)
    {
        Task<string> task1 = GetTemperatureAsync("Bangalore");
        Task<string> task2 = GetTemperatureAsync("Coimbatore");
        Task<string> task3 = GetTemperatureAsync("Mumbai");

        // Await all and print results
        string[] results = await Task.WhenAll(task1, task2, task3);

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

}