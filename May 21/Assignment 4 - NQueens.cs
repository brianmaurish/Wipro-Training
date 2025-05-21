class Program
{
    static int[] x; // Global array to hold column positions of queens
    static int n;

    static void Main(string[] args)
    {
        Console.Write("Enter number of queens (N): ");
        n = int.Parse(Console.ReadLine());
        x = new int[n + 1]; 

        NQueens(1);
    }

    static bool Place(int k, int i)
    {
        for (int j = 1; j < k; j++)
        {
            if (x[j] == i || Math.Abs(x[j] - i) == Math.Abs(j - k))
                return false;
        }
        return true;
    }

    static void NQueens(int k)
    {
        for (int i = 1; i <= n; i++)
        {
            if (Place(k, i))
            {
                x[k] = i;
                if (k == n)
                    PrintSolution();
                else
                    NQueens(k + 1);
            }
        }
    }

    static void PrintSolution()
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (x[i] == j)
                    Console.Write("Q ");
                else
                    Console.Write("_ ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}