using System;

public class HelloWorld
{
    static void PrintArray(int[] numbers)
    {
        for(int i=0;i<numbers.Length;i++)
        {
            Console.WriteLine("Element "+ (i+1)+": "+numbers[i]);
            //Console.WriteLine($"Element {i+1}: {numbers[i]}");
        }
    }
    
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40 };
        PrintArray(arr);
    }
    
}
