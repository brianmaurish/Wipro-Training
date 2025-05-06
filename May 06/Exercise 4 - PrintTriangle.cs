class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());
        PrintTriangle(n);

    }
    static void PrintTriangle(int n)
    {
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}


