class Program
{
    static async Task Main(string[] args)
    {
        var task1 = Task.Run(() => { throw new Exception("Error in Task 1"); });
        var task2 = Task.Run(() => { throw new Exception("Error in Task 2"); });
        var task3 = Task.Run(() => { Console.WriteLine("Task 3 completed"); });
        var task4 = Task.Run(() => { Console.WriteLine("Task 4 completed"); });
        var task5 = Task.Run(() => { Console.WriteLine("Task 5 completed"); });

        try
        {
            await Task.WhenAll(task1, task2, task3, task4, task5);
        }
        catch (AggregateException ex)
        {
            foreach (var innerException in ex.InnerExceptions)
            {
                Console.WriteLine($"Error: {innerException.Message}");
            }
        }
    }
}