class Program
{
    static bool pause = false;
    static bool stop = false;

    static void PrintNumbers()
    {
        int i = 1;
        while (!stop)
        {
            if (pause)
            {
                Console.WriteLine("Thread Paused");
                while (pause)
                {
                    Thread.Sleep(100); 
                }
                Console.WriteLine("Thread Resumed");
            }

            Console.WriteLine(i);
            i++;

            if (i > 100)
            {
                stop = true; 
            }

            Thread.Sleep(50); // Slow down the execution 
        }
    }

    static void Main()
    {
        Thread myThread = new Thread(PrintNumbers);
        myThread.Start();
        Console.WriteLine("Thread state: " + myThread.ThreadState);

        Thread.Sleep(1000);
        pause = true;
        Console.WriteLine("Thread state: " + myThread.ThreadState);

        Thread.Sleep(2000);
        pause = false;;
        Console.WriteLine("Thread state: " + myThread.ThreadState);

    }
}