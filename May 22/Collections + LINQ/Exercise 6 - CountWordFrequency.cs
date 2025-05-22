class Program
{
    public static void Main(String[] args)
    {
        string sentence = "C# is great and C# is fun";

        var words = sentence.Split(' ');

        var a = from word in words
                group word by word into g
                select new {b= g.Key,c= g.Count() };

        foreach(var word in a)
        {
            Console.WriteLine(word.b+ " : "+word.c);
        }
    }
}

