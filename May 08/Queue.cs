class Program
{
    public static void Main()
    {
        //Create a queue of strings
        Queue<string> queue = new Queue<string>();

        //Enqueue elements
        queue.Enqueue("Amit");
        queue.Enqueue("Rohit");
        queue.Enqueue("Ravi");
        queue.Enqueue("Priya");

        Console.WriteLine("Queue Elements: ");
        foreach(var name in queue)
        {
            Console.WriteLine(name);
        }

        //Dequeue elements
        Console.WriteLine("\nDequeued: " + queue.Dequeue());

        //Peek the first element
        Console.WriteLine("Next in the line: " + queue.Peek());
    }
}
