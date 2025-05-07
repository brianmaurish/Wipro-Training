class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        String sentence=Console.ReadLine();
        DuplicateWord(sentence);
    }
    static void DuplicateWord(String sentence)
    {
        string[] str = sentence.Split(' ');
        bool[] visited=new bool[str.Length];
        Console.WriteLine("The duplicate words are: ");
        for (int i = 0; i < str.Length; i++)
        {
            if (visited[i])
                continue;
            bool isDuplicate=false;
            for(int j=i+1;j<str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    visited[j] = true;
                    isDuplicate = true;
                    
                }
            }
            if (isDuplicate)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
