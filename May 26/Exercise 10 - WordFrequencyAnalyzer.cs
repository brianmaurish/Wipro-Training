class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string input = Console.ReadLine();

        string[] words = input.Split(new[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            string lowerWord = word.ToLower(); 
            if (wordCount.ContainsKey(lowerWord))
            {
                wordCount[lowerWord]++;
            }
            else
            {
                wordCount[lowerWord] = 1;
            }
        }

        var top5Words = wordCount.OrderByDescending(w => w.Value)
                         .Take(5)
                         .Select(w => new { Word = w.Key, Frequency = w.Value });

        Console.WriteLine("\nTop 5 most frequent words:");
        foreach (var word in top5Words)
        {
            Console.WriteLine($"Word: {word.Word}, Frequency: {word.Frequency}");
        }
    }
}