class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 7, 4, 2, 3, 5, 6, 2, 8, 9 };
        CountFrequency(arr);
    }
    static void CountFrequency(int[] arr)
    {
        int Count = 1;
        bool[] visited = new bool[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (visited[i])
            {
                continue;
            }
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] == arr[i])
                {
                    Count++;
                    visited[j] = true;
                }

            }
            Console.WriteLine("The element " + arr[i] + " occurs " + Count + " time.");
            Count = 1;
        }
    }
}
