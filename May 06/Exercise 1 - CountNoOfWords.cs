class Program
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);
        Console.WriteLine("Number of words: " + wordCount);
    }
    static int CountWords(string sentence)
    {
        string[] words = sentence.Split(" ");
        return words.Length;
    }
}




