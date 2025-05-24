class Program
{
    static void ProcessItem(object item)
    {
        Console.WriteLine($"Processing item - {item}");
        Thread.Sleep(1000);
        Console.WriteLine($"Processing finished - {item}");
    }
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            ThreadPool.QueueUserWorkItem(ProcessItem,i);
        }
        Console.WriteLine("Main thread continues....");
        Thread.Sleep(3000); //wait for background tasks to complete
        Console.WriteLine("Main thread ends.");
    }
}