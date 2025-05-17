using System.Security.Cryptography.X509Certificates;

abstract class Document
{
    public abstract void PrintContent();
    public void ShowDocumentType()
    {
        Console.WriteLine("Document Type: "+this.GetType().Name);
    }

}
class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word document");
    }
}
class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing PDF document");
    }
}

class Program
{
    public static void Main()
    {
        Document word = new WordDocument();
        word.ShowDocumentType();
        word.PrintContent();

        Document pdf = new PDFDocument();
        pdf.ShowDocumentType();
        pdf.PrintContent();


    }
}