class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        String sentence=Console.ReadLine();
        LongestWord(sentence);
    }
    static void LongestWord(String sentence)
    {
        string[] str = sentence.Split(' ');
        string max=str[0];
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Length>max.Length)
            {
                max= str[i];
            }
        }
        Console.WriteLine("The longest word is: "+max);


    }
}
