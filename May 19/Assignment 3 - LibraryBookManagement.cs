public class Book
{
    public string Title {  get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}
class Program
{
    static void Main()
    {
        Queue<Book> books = new Queue<Book>();
        books.Enqueue(new Book("Harry Potter", "J.K.Rowling"));
        books.Enqueue(new Book("The Hobbit", "J.R.R.Tolking"));
        books.Enqueue(new Book("The Pride", "Jane Austen"));
        books.Enqueue(new Book("To Kill a Mockingbird", "Harper Lee"));
        books.Enqueue(new Book("The Catcher in the Rye", "J.D.Salinger"));

        Console.WriteLine("Next book to be returned: ");
        books.Peek().Display();

        Console.WriteLine("Returning the book.");
        books.Dequeue();

        Stack<Book> newBook = new Stack<Book>();
        newBook.Push(new Book("Python Programming", "Roberst"));
        newBook.Push(new Book("Design Patterns", "Green"));
        newBook.Push(new Book("The code", "Tie"));

        Console.WriteLine("Last book purchased:");
        newBook.Peek().Display();

        newBook.Pop();

        Console.WriteLine("Remaining borrowed in queue:");
        foreach(Book book in books)
        {
            book.Display();
        }

        Console.WriteLine("Remaining new books in stack:");
        foreach (Book book in newBook)
        {
            book.Display();
        }

    }
}