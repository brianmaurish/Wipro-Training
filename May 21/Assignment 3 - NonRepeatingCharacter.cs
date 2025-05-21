class Program
{
    static char FirstNonRepeatingChar(string input)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        // Count frequencies
        foreach (char c in input)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        // Find the first non-repeating character
        foreach (char c in input)
        {
            if (freq[c] == 1)
                return c;
        }

        return '0'; // No non-repeating character found
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char result = FirstNonRepeatingChar(input);

        if (result != '0')
            Console.WriteLine("First non-repeating character: " + result);
        else
            Console.WriteLine("No non-repeating character found.");
    }
}