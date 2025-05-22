class Program
{
    public static void Main(String[] args)
    {
        List<string> list = new List<string> { "Arun", "Henry", "Pooja", "Nivya", "Abishiek", "Raj", "Nithish", "Prakash", "Elango", "Ishan" };
        char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

        var a = from b in list
                where vowels.Contains(b[0])
                select b;

        Console.WriteLine("The names starting with vowels: ");
        foreach(var name in a)
        {
            Console.WriteLine(name);
        }
    }
}

