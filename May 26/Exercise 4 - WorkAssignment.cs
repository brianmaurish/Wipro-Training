class Program
{
    static Queue<string> taskQueue = new Queue<string>();

    static object queueLock = new object();

    static void Main()
    {
        Thread workerThread = new Thread(WorkerThread);
        workerThread.Start();

        for (int i = 1; i <= 5; i++)
        {
            string task = $"Task {i}";
            lock (queueLock)
            {
                taskQueue.Enqueue(task);
                Console.WriteLine($"Enqueued: {task}");
            }

            Thread.Sleep(500);
        }

        workerThread.Join();

        Console.WriteLine("All tasks processed. Exiting program.");
    }

    static void WorkerThread()
    {
        while (true)
        {
            string taskToProcess = null;

            lock (queueLock)
            {
                if (taskQueue.Count > 0)
                {
                    taskToProcess = taskQueue.Dequeue();
                }
            }

            if (taskToProcess != null)
            {
                Console.WriteLine($"Processing {taskToProcess}");
                Thread.Sleep(1000); 
            }
            else
            {
                break;
            }
        }
    }
}