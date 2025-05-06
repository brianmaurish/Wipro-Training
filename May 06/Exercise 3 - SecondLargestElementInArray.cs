class Program
{ 
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine("The second largest element is: " + SecondLargest(arr));

    }
    static int SecondLargest(int[] arr)
    {
        int max = arr[0];
        int secondmax = arr[1];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                secondmax = max;
                max = arr[i];
            }
        }
        return secondmax;
    }
}

