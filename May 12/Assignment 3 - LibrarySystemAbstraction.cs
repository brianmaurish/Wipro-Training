using System.Security.Cryptography.X509Certificates;

abstract class Book
{
    public abstract void Read();
    public void GetInfo()
    {
        Console.WriteLine("This is a book");
    }

}
class FictionBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a fiction book");
    }
}
class ScienceBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a science book");
    }
}

class Program
{
    public static void Main()
    {
        FictionBook book = new FictionBook();
        book.GetInfo();
        book.Read();

        ScienceBook scienceBook = new ScienceBook();
        scienceBook.GetInfo();
        scienceBook.Read();

    }
}