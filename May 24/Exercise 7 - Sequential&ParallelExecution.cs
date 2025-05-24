using System.Diagnostics;

class Program
{
    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine(name + " is running");
        await Task.Delay(delay);
        Console.WriteLine(name + " is completed");
    }

    static async Task Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();

        //Sequential Execution
        Console.WriteLine("Running tasks sequentially...\n");
        sw.Start();
        await SimulateWorkAsync("task 1", 2000);
        await SimulateWorkAsync("task 2", 1000);
        await SimulateWorkAsync("task 3", 3000);
        sw.Stop();
        Console.WriteLine($"\nSequential execution time: {sw.ElapsedMilliseconds} ms\n");

        //Parallel Execution
        Console.WriteLine("Running tasks in parallel using Task.WhenAll...\n");
        sw.Restart();
        Task t1 = SimulateWorkAsync("task 1", 2000);
        Task t2 = SimulateWorkAsync("task 2", 1000);
        Task t3 = SimulateWorkAsync("task 3", 3000);
        await Task.WhenAll(t1, t2, t3);
        sw.Stop();
        Console.WriteLine($"\nParallel execution time: {sw.ElapsedMilliseconds} ms");

    }

}