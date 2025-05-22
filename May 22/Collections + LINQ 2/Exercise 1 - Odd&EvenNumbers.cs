class Program
{
    public static void Main(String[] args)
    {
        List<int> list = new List<int> { 2, 3, 6, 7, 8, 9, 1, 4, 5, 6, };

        var a = from b in list
                where b % 2 == 0
                select b;

        var c = from b in list
                where b % 2 != 0
                select b;

        Console.WriteLine("Even Numbers: ");
        foreach(var num in a)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nOdd Numbers: ");
        foreach (var num in c)
        {
            Console.WriteLine(num);
        }
    }
}

