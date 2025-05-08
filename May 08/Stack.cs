class Program
{
    public static void Main()
    {
        Stack<string> books = new Stack<string>();

        books.Push("C# Programming");
        books.Push("Data Structures");
        books.Push("Macine Learning");

        Console.WriteLine("Books in ths stack : ");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nPopped: " + books.Pop());

        Console.WriteLine("\nNext on the stack: " + books.Peek());

    }
}
