using System.Diagnostics;

class SortingAlgorithms
{
    // Bubble Sort
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    // Selection Sort
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
    // Insertion Sort
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int temp = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;
        }
    }
    public static int[] GenerateRandomArray(int size, int min, int max)
    {
        Random rand = new Random();
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = rand.Next(min, max + 1);
        }
        return result;
    }
    public static void Main()
    {
        int[] original = GenerateRandomArray(20, 1, 100);

        // Display original array
        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(", ", original));

        // Bubble Sort
        int[] bubbleArr = (int[])original.Clone();
        Stopwatch swBubble = Stopwatch.StartNew();
        BubbleSort(bubbleArr);
        swBubble.Stop();
        Console.WriteLine("\nBubble Sort:");
        Console.WriteLine(string.Join(", ", bubbleArr));
        Console.WriteLine($"Time: {swBubble.Elapsed.TotalMilliseconds} ms");

        // Selection Sort
        int[] selectionArr = (int[])original.Clone();
        Stopwatch swSelection = Stopwatch.StartNew();
        SelectionSort(selectionArr);
        swSelection.Stop();
        Console.WriteLine("\nSelection Sort:");
        Console.WriteLine(string.Join(", ", selectionArr));
        Console.WriteLine($"Time: {swSelection.Elapsed.TotalMilliseconds} ms");

        // Insertion Sort
        int[] insertionArr = (int[])original.Clone();
        Stopwatch swInsertion = Stopwatch.StartNew();
        InsertionSort(insertionArr);
        swInsertion.Stop();
        Console.WriteLine("\nInsertion Sort:");
        Console.WriteLine(string.Join(", ", insertionArr));
        Console.WriteLine($"Time: {swInsertion.Elapsed.TotalMilliseconds} ms");
    }
}