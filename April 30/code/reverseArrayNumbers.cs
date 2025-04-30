using System;

public class HelloWorld
{
    static void PrintArray(int[] numbers)
    {
        for(int i=numbers.Length-1;i>=0;i--)
        {
            Console.Write(numbers[i]+" ");
        }
    }
    
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        PrintArray(arr);
    }
    
}
