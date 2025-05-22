class Program
{
    public static void Main(String[] args)
    {
        Dictionary<string,string> book = new Dictionary<string,string>();
        book.Add("Jack", "9875432168");
        book.Add("Naveen", "9876785432");
        book.Add("Shreya", "9878546321");

        foreach(var contact in book)
        {
            Console.WriteLine(contact.Key+ " : "+contact.Value);
        }

        Console.WriteLine("\nEnter the name: ");
        string name=Console.ReadLine();

        if (book.ContainsKey(name))
        {
            Console.WriteLine(book[name]);
        }
        else
        {
            Console.WriteLine("The number is not found");
        }
    }
}
