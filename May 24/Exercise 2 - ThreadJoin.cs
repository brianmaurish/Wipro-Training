class Program
{
    static void Print()
    {
        Console.WriteLine("Printing done...");
    }
    static void Compute()
    {
        Console.WriteLine("Computing done...");
    }
    static void Wait()
    {
        Console.WriteLine("Waiting done...");
    }

    static void Main()
    {
        Thread t1 = new Thread(Print);
        t1.Start();

        Thread t2 = new Thread(Compute);
        t2.Start();

        Thread t3 = new Thread(Wait);
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
        Console.WriteLine("All tasks done");


    }
}