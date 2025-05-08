class Program
{
    public static void Main()
    {
        Queue<string> customers = new Queue<string>();

        customers.Enqueue("Swetha");
        customers.Enqueue("Arun");
        customers.Enqueue("Mohit");
        customers.Enqueue("Jose");

        Console.WriteLine("Serving customers: ");
        while (customers.Count > 0) 
        {
            Console.WriteLine("Serving: " + customers.Dequeue());
         }
      
    }
}
