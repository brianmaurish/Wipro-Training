using System;

public class HelloWorld
{
    static void FindPairSum(int[] arr,int targetsum)
    {
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i]+arr[j]==targetsum)
                {
                    Console.WriteLine(arr[i]+"+"+arr[j]+"="+targetsum);
                }
            }
        }
    }
    public static void Main(string[] args)
    {
        int[] arr={1,2,3,4,5,6,9};
        int targetsum=6;
        
        FindPairSum(arr,targetsum);
    }
}