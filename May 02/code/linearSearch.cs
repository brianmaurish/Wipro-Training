// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int Findindex(int[] num,int target)
    {
        for(int i=0;i<num.Length;i++)
        {
            if(num[i]==target)
            {
                return i;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        int[] arr={2,6,3,1,9,4,7,8};
        int target = 9;
        int result=Findindex(arr,target);
        if(result==-1)
        {
            Console.WriteLine("Element is not found");
        }
        else
        {
            Console.WriteLine("Element is found in index: "+result);
        }
    }
}