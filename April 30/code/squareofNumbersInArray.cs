using System;

public class HelloWorld
{
    static void PrintArray(int[] numbers)
    {
        for(int i=0;i<numbers.Length;i++)
        {
            Console.Write(numbers[i]*numbers[i]+" ");
            //Console.Write(Math.Pow(numbers[i],2)+" ");
        }
    }
    
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        PrintArray(arr);
    }
    
}
