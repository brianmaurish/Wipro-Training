using System;

public class HelloWorld
{
    static void bubblesort(int[] arr)
    {
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    int temp=arr[j+1];
                    arr[j+1]=arr[j];
                    arr[j]=temp;
                }
            }
        }
    }
    public static void Main(string[] args)
    {
        int[] arr={4,5,2,3,8,9,1};

        bubblesort(arr);
        
        Console.Write("Sorted Arraay: ");
        foreach(int num in arr)
        {
            Console.Write(num+" ");
        }
        
    }
}